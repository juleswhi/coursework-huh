﻿
// -- Serializer.cs -- 
//
// This file contains classes which deal with the Serialization of Deserialization of QON
// QON stands for ( Question Object Notation ) and is used to store question details on disk

using System.Text;
using static System.Char;
using static System.String;
using static ChessMasterQuiz.Misc.TokenType;


// The QonConvert class and its associated classes ( Lexer, Parser, Token )
// should be kept in a different namespace to keep things tidy 
namespace ChessMasterQuiz.Misc;

/// <summary>
/// Qon ( Question Object Notation ) Converter.
/// </summary>

// This static class contains methods which deal with Serializing and Deserializing objects and strings respectively. 
// The QonConvert class is able to Serialize both Questions and Users
// It uses overloading so only one method call is needed
public static class QonConvert
{
    // Serialize a question into a Qon String
    public static string Serialize(Question question)
    {
        // StringBuilder is used as it is much faster than traditional string concat.
        // This becomes nesessary when working with large strings ( 100+ concat operations )
        StringBuilder stringBuilder = new();

        // Improvement to be made:
        // Use reflection to get types at runtime, loop through them and append to stringBuilder
        _ = stringBuilder.Append($"Type:\"{(int)question.Type}\",");
        _ = stringBuilder.Append($"Name:\"{question.Name}\",");
        _ = stringBuilder.Append($"Rating:\"{question.Rating}\",");

        // If the question is a TextQuestion:
        // Loop through potential answers and append them to stringBuilder 
        // Also append the Index and Q fields to the stringBuilder

        // Improvement to be made:
        // Whenm multiple different types of questions are implemented
        // it would be time consuming to manually do this.
        // Once again use reflection 
        if (question is TextQuestion)
        {
            _ = stringBuilder.Append("{");
            TextQuestion tq = (question as TextQuestion)!;
            _ = stringBuilder.Append($"Q:\"{tq.Q}\",");
            for (int i = 0; i < tq.A!.Answers.Count; i++)
            {
                _ = stringBuilder.Append($"Answer{i + 1}:\"{tq.A.Answers[i]}\",");
            }
            _ = stringBuilder.Append($"Index:\"{tq.A.Index}\"");
            _ = stringBuilder.Append("}");
        }

        // Return the final build string
        return stringBuilder.ToString();
    }

    public static List<Question> Deserialize(params string[] strs)
    {
        List<Question> questions = new();
        foreach (var str in strs)
        {
            if (IsNullOrWhiteSpace(str))
            {
                continue;
            }

            List<Token> tokens = Lexer.Lex(str);
            Question question = Parser.Parse(tokens);
            questions.Add(question);
        }
        return questions;
    }
}

// This enum represents the different `Tokens` that are found in the Lon strings
public enum TokenType
{
    COLON,
    LEFT_BRACKET,
    RIGHT_BRACKET,
    IDENTIFIER,
    DATA
}

// Class representing the actual Token value
file class Token
{
    // The specific type of `Token` 
    public TokenType Type { get; init; }
    // The data that is attached to the `Type`
    // This is only applicable to `IDENTIFIER` and `DATA`
    // Nullable as some `Types` do not have associated data
    public object? Data { get; init; }

    // This method allows for deconstruction of a Token
    // Deconstruction is the breaking down of complex types into simpler ones
    // Example:
    // ( token, data ) = TokenName;
    public void Deconstruct(out TokenType type, out object? data)
    {
        type = Type;
        data = Data;
    }

    // Simple constructor for the `Token` type
    public Token(TokenType type, object data)
    {
        Type = type;
        Data = data;
    }

    // This constructor can be used if no data is present.
    // However, an exception will be thrown if either a `DATA` or an `IDENTIFER` passed
    public Token(TokenType type)
    {
        if (type == DATA || type == IDENTIFIER)
        {
            throw new Exception();
        }

        Type = type;
        Data = null;
    }
}

// File scoped namespace
// This class deals with Lexical Analysis

// Lexical Analysis is taking a string of text  
// and converting it into a string of tokens.
//
// Example string: Name:"test"
// Example tokens: IDENTIFIER - COLON - DATA

// This is a common technique in building programming languages.
file static class Lexer
{
    // This is a pointer to the current char in the string 
    // ( The char to be evaluated ) 
    private static int _current;

    // The list of `Tokens` which will be returned to the consumer
    private static List<Token> _tokens = new();

    // These methods deal with navigating the string

    // An example of why they are necessary is how programming languages deal with the `=` sign
    // When a programming language interpreter sees a `=`, 
    // it doesn't know if it is an assignment operator, or a comparasin operator
    // therefor it needs to see the next token before evaluating itself.
    // The same concept is used here

    // Next is used to iterate to the next char ( represented by `_current` ) 
    private static void Next(int step = 1)
    {
        _current += step;
    }

    // The `Peek` method is used to look at the next char in the str
    // w/o having to increment the _current variable
    private static char Peek(ReadOnlySpan<char> str)
    {
        return str[_current + 1];
    }

    // The `Current` method is ued to look at the current char in the str 
    // Perhaps the most important helper method here
    private static char Current(ReadOnlySpan<char> str)
    {
        return str[_current];
    }

    // The `Consume` method adds the `token` to the list, 
    // and moves onto the next char to be evaluated
    private static void Consume(Token token)
    {
        _tokens.Add(token);
        _current++;
    }

    // This Lex method contains the actual loop of evaluation
    // It takes in a string `input` which is the list of chars
    public static List<Token> Lex(string input)
    {
        // Due to speed concerns with many evaluations,
        // it improves performance by first converting the
        // string to a `ReadOnlySpan`, which is must faster
        // due to it's lack of writing ability.
        ReadOnlySpan<char> str = input.AsSpan();

        // Becuase the method is static, 
        // the fields should be reset to default
        _current = 0;
        _tokens = new();

        // This loop does not contain any initialization or incrementor
        // This is because it is handled by the helper methods mentioned previously
        for (; _current < str.Length;)
        {
            // Most of the tokens are single character, 
            // so no look ahead is needed.
            switch (Current(str))
            {
                case ':':
                    Consume(new Token(COLON));
                    break;
                case ',':
                    Next();
                    break;
                case '{':
                    Consume(new Token(LEFT_BRACKET));
                    break;
                case '}':
                    Consume(new Token(RIGHT_BRACKET));
                    break;
                case '"':
                    {

                        // If there is a ("), then the token should be of type `DATA`
                        // The `Next()` is needed to proceed to the first character in the string
                        Next();

                        // StringBuilder is used for performance
                        StringBuilder sb = new();

                        // Loop through chars, until the second (")
                        // While in the string, append the current char to the StringBuilder 
                        while (Current(str) != '"')
                        {
                            _ = sb.Append(Current(str));
                            // Jump to next char in the string
                            Next();
                        }

                        // Finally consume as type `DATA`, with the final string
                        Consume(new Token(DATA, sb.ToString()));

                        break;
                    }

                default:
                    {
                        // Very similar to the `DATA` above

                        // Due to the limitations of variable names,
                        // No (") are necessary, just ensure all chars are letters 
                        StringBuilder sb = new();
                        while (IsLetterOrDigit(Current(str)))
                        {
                            _ = sb.Append(Current(str));
                            Next();
                        }

                        // Finally consume as type `IDENTIFIER`
                        Consume(new Token(IDENTIFIER, sb.ToString()));
                        break;
                    }
            }
        }

        // Return the final list of `Tokens`
        return _tokens;

    }
}

// File scoped namespace
// This static class deals with Parsing Tokens

// The `Parser` class takes a List of Tokens 
// ( From the Lexical Analysis )
// And converts them into useable C# objects.
file static class Parser
{
    private static readonly List<Type> ValidTypes = new()
    {
        typeof(Question),
        typeof(TextQuestion),
        typeof(Answer)
    };
    private static int _current;
    private static List<Token> _tokens = new();

    private static void Next(int step = 1)
    {
        _current += step;
    }

    private static Token Peek()
    {
        return _tokens[_current < _tokens.Count ? _current + 1 : _current];
    }

    private static Token Current()
    {
        return _tokens[_current];
    }

    private static Token Previous()
    {
        return _tokens[_current > 0 ? _current - 1 : _current];
    }

    public static Question Parse(List<Token> tokens)
    {

        _current = 0;
        _tokens = tokens;

        List<string> answers = new();
        int index = 0;

        TextQuestion question = new();

        for (; _current < _tokens.Count;)
        {
            switch (Current().Type)
            {
                case LEFT_BRACKET:
                    break;

                case IDENTIFIER:
                    {
                        var name = Current().Data as string;


                        PropertyInfo? property = null;

                        void GetProps(Type type)
                        {
                            if (!ValidTypes.Contains(type))
                            {
                                return;
                            }

                            var props = type.GetProperties();

                            property = props.FirstOrDefault(
                                x => x.Name == name);

                            if (property is not null)
                            {
                                return;
                            }

                            foreach (var prop in props)
                            {
                                GetProps(prop.PropertyType);
                            }
                        }

                        if (name!.ToLower().Contains("answer"))
                        {
                            Next();
                            answers.Add((string)Current().Data!);
                            break;
                        }
                        else if (name.ToLower().Contains("index"))
                        {
                            Next();
                            index = int.Parse((string)Current().Data!);
                            break;
                        }
                        else
                        {
                            GetProps(question.GetType());
                        }

                        if (property is null)
                        {
                            break;
                        }



                        // If null, then identifier must be in the Answers 
                        if (property is null)
                        {
                            // Get type of the question ( TextQuestion etc... ) 
                            // Look up properties recursively

                            if (question.Type == QuestionType.TEXT)
                            {
                                property = CheckForProperties(typeof(Answer), name);
                            }

                            if (property is null)
                            {
                                break;
                            }

                        }

                        Next();

                        // If the property is an enum, then a explicit conversion from stirng -> enum Type is needed
                        if (property!.PropertyType.IsEnum)
                        {
                            _ = Enum.TryParse(property.PropertyType, (string)Current().Data!, out var output);
                            property.SetValue(question, output);
                        }
                        else
                        {
                            property.SetValue(question, Convert.ChangeType(Current().Data, property.PropertyType));
                        }

                        break;
                    }
            }
            Next();
        }

        question.A = new(answers, (uint)index);
        return question;
    }


    private static PropertyInfo? CheckForProperties(Type type, string name)
    {
        var props = type.GetProperties();

        var prop = props.FirstOrDefault(
            x => x.Name == name);

        return prop;
    }
}

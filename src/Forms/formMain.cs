﻿using ChessMasterQuiz.Forms;
using ChessMasterQuiz.Forms.Questions;

namespace ChessMasterQuiz;

public partial class formMain : Form
{
    public static Form? ChildForm { get; set; } = null;
    public static Func<Panel>? GetPanelHolder { get; set; } = null;

    public formMain()
    {
        InitializeComponent();
        GetPanelHolder = () => panelHolder;
        Text = "Chess Master Quiz";
        FormBorderStyle = FormBorderStyle.FixedSingle;
        CenterToScreen();

        Users.ForEach(x => x.Logout());

        var tq = new TypeQuestion("What is this opening called", "London Opening")
        {
            Rating = 1000
        };

        ActivateForm<formSplashScreen>();
        // ActivateForm<formUserProfile>((Users.First()!, USER));
    }
}

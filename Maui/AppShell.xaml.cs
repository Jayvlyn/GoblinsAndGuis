﻿namespace Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(CreationPage), typeof(CreationPage));
        }
    }
}
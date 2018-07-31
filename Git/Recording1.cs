﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Git
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("71b8ff71-b4dd-4980-ba64-1c545b259f1a", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the GitRepository repository.
        /// </summary>
        public static GitRepository repo = GitRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://webtest.ranorex.org/wp-login.php' with browser 'Chrome' in maximized mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://webtest.ranorex.org/wp-login.php", "Chrome", "", false, true, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexWebtestLogIn.UserLogin' at 94;12.", repo.RanorexWebtestLogIn.UserLoginInfo, new RecordItemIndex(1));
            repo.RanorexWebtestLogIn.UserLogin.Click("94;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ranore' with focus on 'RanorexWebtestLogIn.UserLogin'.", repo.RanorexWebtestLogIn.UserLoginInfo, new RecordItemIndex(2));
            repo.RanorexWebtestLogIn.UserLogin.PressKeys("ranore");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'x webtest' with focus on 'RanorexWebtestLogIn.UserLogin'.", repo.RanorexWebtestLogIn.UserLoginInfo, new RecordItemIndex(3));
            repo.RanorexWebtestLogIn.UserLogin.PressKeys("x webtest");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexWebtestLogIn.UserPass' at 80;22.", repo.RanorexWebtestLogIn.UserPassInfo, new RecordItemIndex(4));
            repo.RanorexWebtestLogIn.UserPass.Click("80;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ranorex' with focus on 'RanorexWebtestLogIn.UserPass'.", repo.RanorexWebtestLogIn.UserPassInfo, new RecordItemIndex(5));
            repo.RanorexWebtestLogIn.UserPass.PressKeys("ranorex");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexWebtestLogIn.WpSubmit' at 41;11.", repo.RanorexWebtestLogIn.WpSubmitInfo, new RecordItemIndex(6));
            repo.RanorexWebtestLogIn.WpSubmit.Click("41;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexWebtestLogIn.LogOut' at 42;11.", repo.RanorexWebtestLogIn.LogOutInfo, new RecordItemIndex(7));
            repo.RanorexWebtestLogIn.LogOut.Click("42;11");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

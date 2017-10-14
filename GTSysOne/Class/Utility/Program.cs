namespace GTSysOne.Class.Utility
{
    static class Program
    {
        [System.STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableFormSkinsIfNotVista();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("McSkin");
            GTSysOne.Class.Utility.clsGlobal.Instance().OptimizeConnection = false;
            switch(GTSysOne.Class.Utility.clsUtility.InstanceRunning())
            {
                case false:
                        #region Welcome
                        using (var frm = new GTSysOne.Gui.Main.frmSplash())
                        {
                            frm.ShowDialog();
                            frm.Dispose();
                        }
                        #endregion
                        switch (GTSysOne.Class.Utility.clsGlobal.Instance().LogOut)
                        {
                            case true:
                                #region
                                switch (GTSysOne.Class.Utility.clsGlobal.Instance().CloseFromLogIn)
                                {
                                    case true:
                                        System.Windows.Forms.Application.Restart();
                                        break;
                                    default:
                                        System.Windows.Forms.Application.Exit();
                                        break;
                                }
                                #endregion
                                break;
                            default:
                                GTSysOne.Class.Utility.clsUtility.Proceed();
                                switch (GTSysOne.Class.Utility.clsGlobal.Instance().LicenseAction)
                                {
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Demo:
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Trial:
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.FullVersion:
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.AlmostExpiredSubscription:
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.ExpiredSubscription:

                                        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(GTSysOne.Class.Utility.clsGlobal.Instance().THEME);
                                        System.Windows.Forms.Application.Run(GTSysOne.Gui.Main.frmMain.Instance);
                                        GTSysOne.Class.Utility.clsUtility.UPDATERUNNINGCPU(false);
                                        break;
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.Copyright:
                                    case GTSysOne.Class.Utility.clsGlobal.myLicenseStatus.JustClose:
                                        GTSysOne.Class.Utility.clsUtility.UPDATERUNNINGCPU(false);
                                        System.Windows.Forms.Application.Exit();
                                        break;
                                }
                                switch (GTSysOne.Class.Utility.clsGlobal.Instance().LogOut)
                                {
                                    case true:
                                        System.Windows.Forms.Application.Restart();
                                        break;
                                }
                                break;
                        }
                    break;
                default:
                    break;
            }
        }
    }
}

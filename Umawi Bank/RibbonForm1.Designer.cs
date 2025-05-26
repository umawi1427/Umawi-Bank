namespace Umawi_Bank
{
    partial class RibbonForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm1));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.profileinformation = new DevExpress.XtraBars.BarButtonItem();
            this.editprofile = new DevExpress.XtraBars.BarButtonItem();
            this.deletemybankaccount = new DevExpress.XtraBars.BarButtonItem();
            this.logoutbutton = new DevExpress.XtraBars.BarButtonItem();
            this.createaccount = new DevExpress.XtraBars.BarButtonItem();
            this.viewaccounts = new DevExpress.XtraBars.BarButtonItem();
            this.deleteaccount = new DevExpress.XtraBars.BarButtonItem();
            this.applyforloan = new DevExpress.XtraBars.BarButtonItem();
            this.viewloans = new DevExpress.XtraBars.BarButtonItem();
            this.debtrepayment = new DevExpress.XtraBars.BarButtonItem();
            this.copyaccountinformation = new DevExpress.XtraBars.BarButtonItem();
            this.transfermoney = new DevExpress.XtraBars.BarButtonItem();
            this.buyforeigncurrency = new DevExpress.XtraBars.BarButtonItem();
            this.transactionhistory = new DevExpress.XtraBars.BarButtonItem();
            this.bankstatement = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.email = new DevExpress.XtraBars.BarStaticItem();
            this.phone = new DevExpress.XtraBars.BarStaticItem();
            this.address = new DevExpress.XtraBars.BarStaticItem();
            this.individual = new DevExpress.XtraBars.BarButtonItem();
            this.general = new DevExpress.XtraBars.BarButtonItem();
            this.sendmessage = new DevExpress.XtraBars.BarButtonItem();
            this.profile = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.profilemanagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.balance = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.balancemanagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.accountmanagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.accountsmanaegment = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.transactions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.transactionsmanagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.reports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.reportsmanagement = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.logout = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.logouttab = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.contact = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.contactinformation = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.sellforeigncurrency = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(240, 248, 240, 248);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.profileinformation,
            this.editprofile,
            this.deletemybankaccount,
            this.logoutbutton,
            this.createaccount,
            this.viewaccounts,
            this.deleteaccount,
            this.applyforloan,
            this.viewloans,
            this.debtrepayment,
            this.copyaccountinformation,
            this.transfermoney,
            this.buyforeigncurrency,
            this.transactionhistory,
            this.bankstatement,
            this.barStaticItem1,
            this.email,
            this.phone,
            this.address,
            this.individual,
            this.general,
            this.sendmessage});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(24);
            this.ribbon.MaxItemId = 30;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 2640;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.profile,
            this.balance,
            this.accountmanagement,
            this.transactions,
            this.reports,
            this.logout,
            this.contact});
            this.ribbon.Size = new System.Drawing.Size(2684, 308);
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // profileinformation
            // 
            this.profileinformation.Caption = "profile information";
            this.profileinformation.Id = 1;
            this.profileinformation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("profileinformation.ImageOptions.SvgImage")));
            this.profileinformation.Name = "profileinformation";
            this.profileinformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.profileinformation_ItemClick);
            // 
            // editprofile
            // 
            this.editprofile.Caption = "edit profile";
            this.editprofile.Id = 2;
            this.editprofile.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editprofile.ImageOptions.SvgImage")));
            this.editprofile.Name = "editprofile";
            this.editprofile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editprofile_ItemClick);
            // 
            // deletemybankaccount
            // 
            this.deletemybankaccount.Caption = "delete my bank account";
            this.deletemybankaccount.Id = 3;
            this.deletemybankaccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("deletemybankaccount.ImageOptions.SvgImage")));
            this.deletemybankaccount.Name = "deletemybankaccount";
            this.deletemybankaccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deletemybankaccount_ItemClick);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Caption = "logout";
            this.logoutbutton.Id = 4;
            this.logoutbutton.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("logoutbutton.ImageOptions.SvgImage")));
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logoutbutton_ItemClick);
            // 
            // createaccount
            // 
            this.createaccount.Caption = "create account";
            this.createaccount.Id = 5;
            this.createaccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("createaccount.ImageOptions.SvgImage")));
            this.createaccount.Name = "createaccount";
            this.createaccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.createaccount_ItemClick);
            // 
            // viewaccounts
            // 
            this.viewaccounts.Caption = "view accounts";
            this.viewaccounts.Id = 6;
            this.viewaccounts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("viewaccounts.ImageOptions.SvgImage")));
            this.viewaccounts.Name = "viewaccounts";
            this.viewaccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewaccounts_ItemClick);
            // 
            // deleteaccount
            // 
            this.deleteaccount.Caption = "delete account";
            this.deleteaccount.Id = 7;
            this.deleteaccount.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("deleteaccount.ImageOptions.SvgImage")));
            this.deleteaccount.Name = "deleteaccount";
            this.deleteaccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteaccount_ItemClick);
            // 
            // applyforloan
            // 
            this.applyforloan.Caption = "apply for loan";
            this.applyforloan.Id = 8;
            this.applyforloan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("applyforloan.ImageOptions.SvgImage")));
            this.applyforloan.Name = "applyforloan";
            // 
            // viewloans
            // 
            this.viewloans.Caption = "view loans";
            this.viewloans.Id = 9;
            this.viewloans.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("viewloans.ImageOptions.SvgImage")));
            this.viewloans.Name = "viewloans";
            // 
            // debtrepayment
            // 
            this.debtrepayment.Caption = "debt repayment";
            this.debtrepayment.Id = 10;
            this.debtrepayment.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("debtrepayment.ImageOptions.SvgImage")));
            this.debtrepayment.Name = "debtrepayment";
            // 
            // copyaccountinformation
            // 
            this.copyaccountinformation.Caption = "copy account information";
            this.copyaccountinformation.Id = 12;
            this.copyaccountinformation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("copyaccountinformation.ImageOptions.SvgImage")));
            this.copyaccountinformation.Name = "copyaccountinformation";
            this.copyaccountinformation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.copyaccountinformation_ItemClick);
            // 
            // transfermoney
            // 
            this.transfermoney.Caption = "transfer money";
            this.transfermoney.Id = 13;
            this.transfermoney.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("transfermoney.ImageOptions.SvgImage")));
            this.transfermoney.Name = "transfermoney";
            this.transfermoney.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.transfermoney_ItemClick);
            // 
            // buyforeigncurrency
            // 
            this.buyforeigncurrency.Caption = "exchange between accounts";
            this.buyforeigncurrency.Id = 14;
            this.buyforeigncurrency.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buyforeigncurrency.ImageOptions.SvgImage")));
            this.buyforeigncurrency.Name = "buyforeigncurrency";
            this.buyforeigncurrency.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.buyforeigncurrency_ItemClick);
            // 
            // transactionhistory
            // 
            this.transactionhistory.Caption = "transaction history";
            this.transactionhistory.Id = 16;
            this.transactionhistory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("transactionhistory.ImageOptions.SvgImage")));
            this.transactionhistory.Name = "transactionhistory";
            this.transactionhistory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.transactionhistory_ItemClick);
            // 
            // bankstatement
            // 
            this.bankstatement.Caption = "bank statement";
            this.bankstatement.Id = 17;
            this.bankstatement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bankstatement.ImageOptions.SvgImage")));
            this.bankstatement.Name = "bankstatement";
            this.bankstatement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bankstatement_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 21;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // email
            // 
            this.email.Caption = "email: umawi1427@gmail.com";
            this.email.Id = 23;
            this.email.Name = "email";
            // 
            // phone
            // 
            this.phone.Caption = "phone number: +905398791427";
            this.phone.Id = 24;
            this.phone.Name = "phone";
            // 
            // address
            // 
            this.address.Caption = "address: Elazig, Turkey";
            this.address.Id = 25;
            this.address.Name = "address";
            // 
            // individual
            // 
            this.individual.Caption = "individual";
            this.individual.Id = 26;
            this.individual.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("individual.ImageOptions.SvgImage")));
            this.individual.Name = "individual";
            this.individual.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.individual_ItemClick);
            // 
            // general
            // 
            this.general.Caption = "general";
            this.general.Id = 27;
            this.general.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("general.ImageOptions.SvgImage")));
            this.general.Name = "general";
            this.general.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.general_ItemClick);
            // 
            // sendmessage
            // 
            this.sendmessage.Caption = "message";
            this.sendmessage.Id = 28;
            this.sendmessage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sendmessage.ImageOptions.SvgImage")));
            this.sendmessage.Name = "sendmessage";
            this.sendmessage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.sendmessage_ItemClick);
            // 
            // profile
            // 
            this.profile.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.profilemanagement});
            this.profile.Name = "profile";
            this.profile.Text = "Profile";
            // 
            // profilemanagement
            // 
            this.profilemanagement.ItemLinks.Add(this.profileinformation);
            this.profilemanagement.ItemLinks.Add(this.editprofile);
            this.profilemanagement.ItemLinks.Add(this.deletemybankaccount);
            this.profilemanagement.Name = "profilemanagement";
            // 
            // balance
            // 
            this.balance.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.balancemanagement});
            this.balance.Name = "balance";
            this.balance.Text = "balance";
            // 
            // balancemanagement
            // 
            this.balancemanagement.ItemLinks.Add(this.individual);
            this.balancemanagement.ItemLinks.Add(this.general);
            this.balancemanagement.Name = "balancemanagement";
            // 
            // accountmanagement
            // 
            this.accountmanagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.accountsmanaegment});
            this.accountmanagement.Name = "accountmanagement";
            this.accountmanagement.Text = "account management";
            // 
            // accountsmanaegment
            // 
            this.accountsmanaegment.ItemLinks.Add(this.createaccount);
            this.accountsmanaegment.ItemLinks.Add(this.viewaccounts);
            this.accountsmanaegment.ItemLinks.Add(this.deleteaccount);
            this.accountsmanaegment.ItemLinks.Add(this.copyaccountinformation);
            this.accountsmanaegment.Name = "accountsmanaegment";
            // 
            // transactions
            // 
            this.transactions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.transactionsmanagement});
            this.transactions.Name = "transactions";
            this.transactions.Text = "transactions";
            // 
            // transactionsmanagement
            // 
            this.transactionsmanagement.ItemLinks.Add(this.transfermoney);
            this.transactionsmanagement.ItemLinks.Add(this.buyforeigncurrency);
            this.transactionsmanagement.Name = "transactionsmanagement";
            // 
            // reports
            // 
            this.reports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.reportsmanagement});
            this.reports.Name = "reports";
            this.reports.Text = "reports";
            // 
            // reportsmanagement
            // 
            this.reportsmanagement.ItemLinks.Add(this.transactionhistory);
            this.reportsmanagement.ItemLinks.Add(this.bankstatement);
            this.reportsmanagement.Name = "reportsmanagement";
            // 
            // logout
            // 
            this.logout.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.logouttab});
            this.logout.Name = "logout";
            this.logout.Text = "logout";
            // 
            // logouttab
            // 
            this.logouttab.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.logouttab.ItemLinks.Add(this.logoutbutton);
            this.logouttab.Name = "logouttab";
            // 
            // contact
            // 
            this.contact.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.contactinformation});
            this.contact.Name = "contact";
            this.contact.Text = "contact";
            // 
            // contactinformation
            // 
            this.contactinformation.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.contactinformation.ItemLinks.Add(this.sendmessage);
            this.contactinformation.ItemLinks.Add(this.email);
            this.contactinformation.ItemLinks.Add(this.phone);
            this.contactinformation.ItemLinks.Add(this.address);
            this.contactinformation.Name = "contactinformation";
            this.contactinformation.Text = "contact";
            // 
            // sellforeigncurrency
            // 
            this.sellforeigncurrency.Caption = "sell foreign currency";
            this.sellforeigncurrency.Id = 15;
            this.sellforeigncurrency.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("sellforeigncurrency.ImageOptions.SvgImage")));
            this.sellforeigncurrency.Name = "sellforeigncurrency";
            // 
            // RibbonForm1
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Cyan;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2684, 1534);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("RibbonForm1.IconOptions.SvgImage")));
            this.InactiveGlowColor = System.Drawing.Color.Transparent;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RibbonForm1";
            this.Ribbon = this.ribbon;
            this.Text = "Umawi Bank";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage profile;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup profilemanagement;
        private DevExpress.XtraBars.BarButtonItem profileinformation;
        private DevExpress.XtraBars.BarButtonItem editprofile;
        private DevExpress.XtraBars.BarButtonItem deletemybankaccount;
        private DevExpress.XtraBars.Ribbon.RibbonPage accountmanagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup accountsmanaegment;
        private DevExpress.XtraBars.BarButtonItem logoutbutton;
        private DevExpress.XtraBars.Ribbon.RibbonPage logout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup logouttab;
        private DevExpress.XtraBars.BarButtonItem createaccount;
        private DevExpress.XtraBars.BarButtonItem viewaccounts;
        private DevExpress.XtraBars.BarButtonItem deleteaccount;
        private DevExpress.XtraBars.BarButtonItem applyforloan;
        private DevExpress.XtraBars.BarButtonItem viewloans;
        private DevExpress.XtraBars.BarButtonItem debtrepayment;
        private DevExpress.XtraBars.BarButtonItem copyaccountinformation;
        private DevExpress.XtraBars.Ribbon.RibbonPage transactions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup transactionsmanagement;
        private DevExpress.XtraBars.BarButtonItem transfermoney;
        private DevExpress.XtraBars.BarButtonItem buyforeigncurrency;
        private DevExpress.XtraBars.Ribbon.RibbonPage reports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup reportsmanagement;
        private DevExpress.XtraBars.BarButtonItem transactionhistory;
        private DevExpress.XtraBars.BarButtonItem bankstatement;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPage contact;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup contactinformation;
        private DevExpress.XtraBars.BarStaticItem email;
        private DevExpress.XtraBars.BarStaticItem phone;
        private DevExpress.XtraBars.BarStaticItem address;
        private DevExpress.XtraBars.BarButtonItem individual;
        private DevExpress.XtraBars.Ribbon.RibbonPage balance;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup balancemanagement;
        private DevExpress.XtraBars.BarButtonItem general;
        private DevExpress.XtraBars.BarButtonItem sendmessage;
        private DevExpress.XtraBars.BarButtonItem sellforeigncurrency;
    }
}
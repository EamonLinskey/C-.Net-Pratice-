namespace WindowsFormsApp4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pizzaLabel = new System.Windows.Forms.Label();
            this.toppingLabel = new System.Windows.Forms.Label();
            this.diningLabel = new System.Windows.Forms.Label();
            this.deliveryRadioButton = new System.Windows.Forms.RadioButton();
            this.dineInRadioButton = new System.Windows.Forms.RadioButton();
            this.deliveryRadioButton3 = new System.Windows.Forms.RadioButton();
            this.donateRadioButton = new System.Windows.Forms.RadioButton();
            this.pepperoniCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.frogLegsCheckBox = new System.Windows.Forms.CheckBox();
            this.tooMuchCheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pepperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jAzzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.andSaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.button1.Location = new System.Drawing.Point(501, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(511, 178);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Google";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pizzaLabel
            // 
            this.pizzaLabel.AutoSize = true;
            this.pizzaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.pizzaLabel.Location = new System.Drawing.Point(89, 44);
            this.pizzaLabel.Name = "pizzaLabel";
            this.pizzaLabel.Size = new System.Drawing.Size(227, 31);
            this.pizzaLabel.TabIndex = 3;
            this.pizzaLabel.Text = "Pizza Order Form";
            // 
            // toppingLabel
            // 
            this.toppingLabel.AutoSize = true;
            this.toppingLabel.Location = new System.Drawing.Point(34, 18);
            this.toppingLabel.Name = "toppingLabel";
            this.toppingLabel.Size = new System.Drawing.Size(79, 13);
            this.toppingLabel.TabIndex = 4;
            this.toppingLabel.Text = "Select Topping";
            // 
            // diningLabel
            // 
            this.diningLabel.AutoSize = true;
            this.diningLabel.Location = new System.Drawing.Point(13, 11);
            this.diningLabel.Name = "diningLabel";
            this.diningLabel.Size = new System.Drawing.Size(76, 13);
            this.diningLabel.TabIndex = 5;
            this.diningLabel.Text = "Dining Options";
            // 
            // deliveryRadioButton
            // 
            this.deliveryRadioButton.AutoSize = true;
            this.deliveryRadioButton.Location = new System.Drawing.Point(43, 40);
            this.deliveryRadioButton.Name = "deliveryRadioButton";
            this.deliveryRadioButton.Size = new System.Drawing.Size(58, 17);
            this.deliveryRadioButton.TabIndex = 6;
            this.deliveryRadioButton.TabStop = true;
            this.deliveryRadioButton.Text = "Pickup";
            this.deliveryRadioButton.UseVisualStyleBackColor = true;
            this.deliveryRadioButton.CheckedChanged += new System.EventHandler(this.deliveryRadioButton_CheckedChanged);
            // 
            // dineInRadioButton
            // 
            this.dineInRadioButton.AutoSize = true;
            this.dineInRadioButton.Location = new System.Drawing.Point(43, 63);
            this.dineInRadioButton.Name = "dineInRadioButton";
            this.dineInRadioButton.Size = new System.Drawing.Size(58, 17);
            this.dineInRadioButton.TabIndex = 7;
            this.dineInRadioButton.TabStop = true;
            this.dineInRadioButton.Text = "Dine in";
            this.dineInRadioButton.UseVisualStyleBackColor = true;
            this.dineInRadioButton.CheckedChanged += new System.EventHandler(this.dineInRadioButton_CheckedChanged);
            // 
            // deliveryRadioButton3
            // 
            this.deliveryRadioButton3.AutoSize = true;
            this.deliveryRadioButton3.Location = new System.Drawing.Point(43, 86);
            this.deliveryRadioButton3.Name = "deliveryRadioButton3";
            this.deliveryRadioButton3.Size = new System.Drawing.Size(61, 17);
            this.deliveryRadioButton3.TabIndex = 8;
            this.deliveryRadioButton3.TabStop = true;
            this.deliveryRadioButton3.Text = "delivery";
            this.deliveryRadioButton3.UseVisualStyleBackColor = true;
            this.deliveryRadioButton3.CheckedChanged += new System.EventHandler(this.deliveryRadioButton3_CheckedChanged);
            // 
            // donateRadioButton
            // 
            this.donateRadioButton.AutoSize = true;
            this.donateRadioButton.Location = new System.Drawing.Point(43, 109);
            this.donateRadioButton.Name = "donateRadioButton";
            this.donateRadioButton.Size = new System.Drawing.Size(147, 17);
            this.donateRadioButton.TabIndex = 9;
            this.donateRadioButton.TabStop = true;
            this.donateRadioButton.Text = "donate pizza to the troops";
            this.donateRadioButton.UseVisualStyleBackColor = true;
            this.donateRadioButton.CheckedChanged += new System.EventHandler(this.donateRadioButton_CheckedChanged);
            // 
            // pepperoniCheckBox
            // 
            this.pepperoniCheckBox.AutoSize = true;
            this.pepperoniCheckBox.Location = new System.Drawing.Point(16, 32);
            this.pepperoniCheckBox.Name = "pepperoniCheckBox";
            this.pepperoniCheckBox.Size = new System.Drawing.Size(74, 17);
            this.pepperoniCheckBox.TabIndex = 10;
            this.pepperoniCheckBox.Text = "Pepperoni";
            this.pepperoniCheckBox.UseVisualStyleBackColor = true;
            this.pepperoniCheckBox.CheckedChanged += new System.EventHandler(this.pepperoniCheckBox_CheckedChanged);
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(16, 56);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(54, 17);
            this.onionCheckBox.TabIndex = 11;
            this.onionCheckBox.Text = "Onion";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.CheckedChanged += new System.EventHandler(this.onionCheckBox_CheckedChanged);
            // 
            // frogLegsCheckBox
            // 
            this.frogLegsCheckBox.AutoSize = true;
            this.frogLegsCheckBox.Location = new System.Drawing.Point(16, 78);
            this.frogLegsCheckBox.Name = "frogLegsCheckBox";
            this.frogLegsCheckBox.Size = new System.Drawing.Size(73, 17);
            this.frogLegsCheckBox.TabIndex = 12;
            this.frogLegsCheckBox.Text = "Frog Legs";
            this.frogLegsCheckBox.UseVisualStyleBackColor = true;
            this.frogLegsCheckBox.CheckedChanged += new System.EventHandler(this.frogLegsCheckBox_CheckedChanged);
            // 
            // tooMuchCheeseCheckBox
            // 
            this.tooMuchCheeseCheckBox.AutoSize = true;
            this.tooMuchCheeseCheckBox.Location = new System.Drawing.Point(16, 102);
            this.tooMuchCheeseCheckBox.Name = "tooMuchCheeseCheckBox";
            this.tooMuchCheeseCheckBox.Size = new System.Drawing.Size(114, 17);
            this.tooMuchCheeseCheckBox.TabIndex = 13;
            this.tooMuchCheeseCheckBox.Text = "Too Much Cheese";
            this.tooMuchCheeseCheckBox.UseVisualStyleBackColor = true;
            this.tooMuchCheeseCheckBox.CheckedChanged += new System.EventHandler(this.tooMuchCheeseCheckBox_CheckedChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(37, 229);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(58, 13);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Specialty";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "None",
            "Hawaian",
            "Crazy town",
            "Over teh moon",
            "Taco",
            "Meat Haters"});
            this.listBox1.Location = new System.Drawing.Point(376, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(92, 82);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onionCheckBox);
            this.panel1.Controls.Add(this.diningLabel);
            this.panel1.Controls.Add(this.pepperoniCheckBox);
            this.panel1.Controls.Add(this.frogLegsCheckBox);
            this.panel1.Controls.Add(this.tooMuchCheeseCheckBox);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 134);
            this.panel1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deliveryRadioButton);
            this.groupBox1.Controls.Add(this.toppingLabel);
            this.groupBox1.Controls.Add(this.dineInRadioButton);
            this.groupBox1.Controls.Add(this.deliveryRadioButton3);
            this.groupBox1.Controls.Add(this.donateRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(175, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 151);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewsToolStripMenuItem,
            this.pizzaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewsToolStripMenuItem
            // 
            this.viewsToolStripMenuItem.Name = "viewsToolStripMenuItem";
            this.viewsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.viewsToolStripMenuItem.Text = "Views";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extraToolStripMenuItem,
            this.pepperToolStripMenuItem,
            this.jAzzToolStripMenuItem});
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extraToolStripMenuItem.Text = "Extra";
            // 
            // pepperToolStripMenuItem
            // 
            this.pepperToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roniToolStripMenuItem,
            this.andSaltToolStripMenuItem});
            this.pepperToolStripMenuItem.Name = "pepperToolStripMenuItem";
            this.pepperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pepperToolStripMenuItem.Text = "Pepper";
            // 
            // jAzzToolStripMenuItem
            // 
            this.jAzzToolStripMenuItem.Name = "jAzzToolStripMenuItem";
            this.jAzzToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jAzzToolStripMenuItem.Text = "JAzz";
            // 
            // roniToolStripMenuItem
            // 
            this.roniToolStripMenuItem.Name = "roniToolStripMenuItem";
            this.roniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.roniToolStripMenuItem.Text = "roni";
            // 
            // andSaltToolStripMenuItem
            // 
            this.andSaltToolStripMenuItem.Name = "andSaltToolStripMenuItem";
            this.andSaltToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.andSaltToolStripMenuItem.Text = "and salt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 309);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pizzaLabel);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "xw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label pizzaLabel;
        private System.Windows.Forms.Label toppingLabel;
        private System.Windows.Forms.Label diningLabel;
        private System.Windows.Forms.RadioButton deliveryRadioButton;
        private System.Windows.Forms.RadioButton dineInRadioButton;
        private System.Windows.Forms.RadioButton deliveryRadioButton3;
        private System.Windows.Forms.RadioButton donateRadioButton;
        private System.Windows.Forms.CheckBox pepperoniCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.CheckBox frogLegsCheckBox;
        private System.Windows.Forms.CheckBox tooMuchCheeseCheckBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pepperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem andSaltToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jAzzToolStripMenuItem;
    }
}


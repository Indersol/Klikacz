
namespace Klikacz
{
    partial class Klikacz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startB = new Button();
            endB = new Button();
            xPositionL = new Label();
            xPosition = new Label();
            yPositionL = new Label();
            yPosition = new Label();
            CoordsLV = new ListView();
            xCord = new ColumnHeader();
            yCord = new ColumnHeader();
            ms = new ColumnHeader();
            key = new ColumnHeader();
            xCordAddTB = new TextBox();
            yCordAddTB = new TextBox();
            msCordAddTB = new TextBox();
            xCordAddLabel = new Label();
            yCordAddLabel = new Label();
            msCordAddLabel = new Label();
            CordAddButton = new Button();
            groupBox1 = new GroupBox();
            isWorkingL = new Label();
            richTextBox1 = new RichTextBox();
            CordClearButton = new Button();
            addCordGB = new GroupBox();
            addKeyGB = new GroupBox();
            keyL = new Label();
            keyTB = new TextBox();
            keyAddButton = new Button();
            groupBox1.SuspendLayout();
            addCordGB.SuspendLayout();
            addKeyGB.SuspendLayout();
            SuspendLayout();
            // 
            // startB
            // 
            startB.Location = new Point(12, 12);
            startB.Name = "startB";
            startB.Size = new Size(98, 23);
            startB.TabIndex = 0;
            startB.Text = "Start";
            startB.UseVisualStyleBackColor = true;
            startB.Click += startB_Click;
            // 
            // endB
            // 
            endB.Location = new Point(116, 12);
            endB.Name = "endB";
            endB.Size = new Size(105, 23);
            endB.TabIndex = 1;
            endB.Text = "Zakończ";
            endB.UseVisualStyleBackColor = true;
            endB.Click += endB_Click;
            // 
            // xPositionL
            // 
            xPositionL.AutoSize = true;
            xPositionL.Location = new Point(333, -2);
            xPositionL.Name = "xPositionL";
            xPositionL.Size = new Size(17, 15);
            xPositionL.TabIndex = 2;
            xPositionL.Text = "X:";
            // 
            // xPosition
            // 
            xPosition.AutoSize = true;
            xPosition.Location = new Point(356, -2);
            xPosition.Name = "xPosition";
            xPosition.Size = new Size(12, 15);
            xPosition.TabIndex = 3;
            xPosition.Text = "-";
            // 
            // yPositionL
            // 
            yPositionL.AutoSize = true;
            yPositionL.Location = new Point(392, -2);
            yPositionL.Name = "yPositionL";
            yPositionL.Size = new Size(17, 15);
            yPositionL.TabIndex = 4;
            yPositionL.Text = "Y:";
            // 
            // yPosition
            // 
            yPosition.AutoSize = true;
            yPosition.Location = new Point(415, -2);
            yPosition.Name = "yPosition";
            yPosition.Size = new Size(12, 15);
            yPosition.TabIndex = 5;
            yPosition.Text = "-";
            // 
            // CoordsLV
            // 
            CoordsLV.Columns.AddRange(new ColumnHeader[] { xCord, yCord, ms, key });
            CoordsLV.Location = new Point(227, 12);
            CoordsLV.Name = "CoordsLV";
            CoordsLV.Size = new Size(245, 345);
            CoordsLV.TabIndex = 6;
            CoordsLV.UseCompatibleStateImageBehavior = false;
            CoordsLV.View = View.Details;
            // 
            // xCord
            // 
            xCord.Tag = "xCord";
            xCord.Text = "xCord";
            // 
            // yCord
            // 
            yCord.Tag = "yCord";
            yCord.Text = "yCord";
            // 
            // ms
            // 
            ms.Tag = "ms";
            ms.Text = "ms";
            // 
            // key
            // 
            key.Tag = "key";
            key.Text = "key";
            // 
            // xCordAddTB
            // 
            xCordAddTB.Location = new Point(35, 22);
            xCordAddTB.Name = "xCordAddTB";
            xCordAddTB.Size = new Size(54, 23);
            xCordAddTB.TabIndex = 7;
            xCordAddTB.KeyPress += xCordAddTB_KeyPress;
            // 
            // yCordAddTB
            // 
            yCordAddTB.Location = new Point(35, 51);
            yCordAddTB.Name = "yCordAddTB";
            yCordAddTB.Size = new Size(54, 23);
            yCordAddTB.TabIndex = 8;
            yCordAddTB.KeyPress += yCordAddTB_KeyPress;
            // 
            // msCordAddTB
            // 
            msCordAddTB.Cursor = Cursors.SizeNS;
            msCordAddTB.Location = new Point(35, 80);
            msCordAddTB.Name = "msCordAddTB";
            msCordAddTB.Size = new Size(54, 23);
            msCordAddTB.TabIndex = 9;
            msCordAddTB.Text = "1000";
            msCordAddTB.KeyPress += msCordAddTB_KeyPress;
            // 
            // xCordAddLabel
            // 
            xCordAddLabel.AutoSize = true;
            xCordAddLabel.Location = new Point(12, 25);
            xCordAddLabel.Name = "xCordAddLabel";
            xCordAddLabel.Size = new Size(17, 15);
            xCordAddLabel.TabIndex = 10;
            xCordAddLabel.Text = "X:";
            // 
            // yCordAddLabel
            // 
            yCordAddLabel.AutoSize = true;
            yCordAddLabel.Location = new Point(12, 54);
            yCordAddLabel.Name = "yCordAddLabel";
            yCordAddLabel.Size = new Size(17, 15);
            yCordAddLabel.TabIndex = 11;
            yCordAddLabel.Text = "Y:";
            // 
            // msCordAddLabel
            // 
            msCordAddLabel.AutoSize = true;
            msCordAddLabel.Location = new Point(3, 83);
            msCordAddLabel.Name = "msCordAddLabel";
            msCordAddLabel.Size = new Size(26, 15);
            msCordAddLabel.TabIndex = 12;
            msCordAddLabel.Text = "ms:";
            // 
            // CordAddButton
            // 
            CordAddButton.Location = new Point(12, 176);
            CordAddButton.Name = "CordAddButton";
            CordAddButton.Size = new Size(98, 23);
            CordAddButton.TabIndex = 13;
            CordAddButton.Text = "Dodaj punkt";
            CordAddButton.UseVisualStyleBackColor = true;
            CordAddButton.Click += CordAddButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(isWorkingL);
            groupBox1.Controls.Add(yPositionL);
            groupBox1.Controls.Add(yPosition);
            groupBox1.Controls.Add(xPositionL);
            groupBox1.Controls.Add(xPosition);
            groupBox1.Location = new Point(12, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 86);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Legenda:";
            // 
            // isWorkingL
            // 
            isWorkingL.AutoSize = true;
            isWorkingL.Location = new Point(436, -2);
            isWorkingL.Name = "isWorkingL";
            isWorkingL.Size = new Size(24, 15);
            isWorkingL.TabIndex = 16;
            isWorkingL.Text = "Off";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Location = new Point(12, 379);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(460, 70);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "Można sterować klawiszami:\nZ - Dodanie pozycji\tX - Ustawienie cordów\nS - Start pętli\t\tA - Stop pętli (nie działa jak \n\t\t\tprogram działa w tle)";
            // 
            // CordClearButton
            // 
            CordClearButton.Location = new Point(12, 205);
            CordClearButton.Name = "CordClearButton";
            CordClearButton.Size = new Size(209, 23);
            CordClearButton.TabIndex = 15;
            CordClearButton.Text = "Wyczyść listę";
            CordClearButton.UseVisualStyleBackColor = true;
            CordClearButton.Click += CordClearButton_Click;
            // 
            // addCordGB
            // 
            addCordGB.Controls.Add(xCordAddTB);
            addCordGB.Controls.Add(yCordAddTB);
            addCordGB.Controls.Add(msCordAddTB);
            addCordGB.Controls.Add(xCordAddLabel);
            addCordGB.Controls.Add(yCordAddLabel);
            addCordGB.Controls.Add(msCordAddLabel);
            addCordGB.Location = new Point(12, 52);
            addCordGB.Name = "addCordGB";
            addCordGB.Size = new Size(98, 118);
            addCordGB.TabIndex = 17;
            addCordGB.TabStop = false;
            addCordGB.Text = "Dodaj klik:";
            // 
            // addKeyGB
            // 
            addKeyGB.Controls.Add(keyL);
            addKeyGB.Controls.Add(keyTB);
            addKeyGB.Location = new Point(116, 55);
            addKeyGB.Name = "addKeyGB";
            addKeyGB.Size = new Size(105, 115);
            addKeyGB.TabIndex = 18;
            addKeyGB.TabStop = false;
            addKeyGB.Text = "Dodaj ciąg:";
            // 
            // keyL
            // 
            keyL.AutoSize = true;
            keyL.Location = new Point(6, 22);
            keyL.Name = "keyL";
            keyL.Size = new Size(68, 15);
            keyL.TabIndex = 1;
            keyL.Text = "Np: 0.00001";
            // 
            // keyTB
            // 
            keyTB.Location = new Point(6, 48);
            keyTB.Name = "keyTB";
            keyTB.Size = new Size(93, 23);
            keyTB.TabIndex = 0;
            keyTB.Text = "0.00001";
            // 
            // keyAddButton
            // 
            keyAddButton.Location = new Point(116, 176);
            keyAddButton.Name = "keyAddButton";
            keyAddButton.Size = new Size(105, 23);
            keyAddButton.TabIndex = 19;
            keyAddButton.Text = "Dodaj ciąg";
            keyAddButton.UseVisualStyleBackColor = true;
            keyAddButton.Click += keyAddButton_Click;
            // 
            // Klikacz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(484, 461);
            Controls.Add(keyAddButton);
            Controls.Add(addKeyGB);
            Controls.Add(addCordGB);
            Controls.Add(richTextBox1);
            Controls.Add(CordClearButton);
            Controls.Add(groupBox1);
            Controls.Add(CordAddButton);
            Controls.Add(CoordsLV);
            Controls.Add(endB);
            Controls.Add(startB);
            MaximizeBox = false;
            Name = "Klikacz";
            Text = "Klikacz";
            KeyDown += Klikacz_KeyDown;
            MouseDown += Klikacz_MouseDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            addCordGB.ResumeLayout(false);
            addCordGB.PerformLayout();
            addKeyGB.ResumeLayout(false);
            addKeyGB.PerformLayout();
            ResumeLayout(false);
        }



        #endregion

        private Button startB;
        private Button endB;
        private Label xPositionL;
        private Label xPosition;
        private Label yPositionL;
        private Label yPosition;
        private ListView CoordsLV;
        private ColumnHeader xCord;
        private ColumnHeader yCord;
        private ColumnHeader ms;
        private TextBox xCordAddTB;
        private TextBox yCordAddTB;
        private TextBox msCordAddTB;
        private Label xCordAddLabel;
        private Label yCordAddLabel;
        private Label msCordAddLabel;
        private Button CordAddButton;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button CordClearButton;
        private Label isWorkingL;
        private ColumnHeader key;
        private GroupBox addCordGB;
        private GroupBox addKeyGB;
        private TextBox keyTB;
        private Label keyL;
        private Button keyAddButton;
    }
}

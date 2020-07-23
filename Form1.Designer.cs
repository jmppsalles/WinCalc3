namespace WinCalc3
{
    partial class form_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Calc));
            this.btn_InvertSign = new System.Windows.Forms.Button();
            this.btn_Cube = new System.Windows.Forms.Button();
            this.btn_Sqr = new System.Windows.Forms.Button();
            this.btn_SqrRoot = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.btn_Invert = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.lbl_Eq = new System.Windows.Forms.Label();
            this.btn_BckSpace = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_InvertSign
            // 
            this.btn_InvertSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InvertSign.Location = new System.Drawing.Point(180, 101);
            this.btn_InvertSign.Name = "btn_InvertSign";
            this.btn_InvertSign.Size = new System.Drawing.Size(49, 51);
            this.btn_InvertSign.TabIndex = 7;
            this.btn_InvertSign.Text = "+/-";
            this.btn_InvertSign.UseVisualStyleBackColor = true;
            this.btn_InvertSign.Click += new System.EventHandler(this.btn_InvertSign_Click);
            // 
            // btn_Cube
            // 
            this.btn_Cube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cube.Location = new System.Drawing.Point(423, 159);
            this.btn_Cube.Name = "btn_Cube";
            this.btn_Cube.Size = new System.Drawing.Size(49, 51);
            this.btn_Cube.TabIndex = 6;
            this.btn_Cube.Text = "^";
            this.btn_Cube.UseVisualStyleBackColor = true;
            this.btn_Cube.Click += new System.EventHandler(this.btn_Operator);
            // 
            // btn_Sqr
            // 
            this.btn_Sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sqr.Location = new System.Drawing.Point(423, 102);
            this.btn_Sqr.Name = "btn_Sqr";
            this.btn_Sqr.Size = new System.Drawing.Size(49, 51);
            this.btn_Sqr.TabIndex = 5;
            this.btn_Sqr.Text = "x^2";
            this.btn_Sqr.UseVisualStyleBackColor = true;
            this.btn_Sqr.Click += new System.EventHandler(this.btn_Sqr_Click);
            // 
            // btn_SqrRoot
            // 
            this.btn_SqrRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SqrRoot.Location = new System.Drawing.Point(367, 102);
            this.btn_SqrRoot.Name = "btn_SqrRoot";
            this.btn_SqrRoot.Size = new System.Drawing.Size(49, 51);
            this.btn_SqrRoot.TabIndex = 4;
            this.btn_SqrRoot.Text = "√ ";
            this.btn_SqrRoot.UseVisualStyleBackColor = true;
            this.btn_SqrRoot.Click += new System.EventHandler(this.btn_SqrRoot_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(180, 159);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(49, 51);
            this.button9.TabIndex = 11;
            this.button9.Text = "/";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btn_Operator);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(125, 159);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 51);
            this.button10.TabIndex = 10;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btn_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(70, 159);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(49, 51);
            this.button11.TabIndex = 9;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.btn_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(15, 159);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(49, 51);
            this.button12.TabIndex = 8;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btn_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(180, 216);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(49, 51);
            this.button13.TabIndex = 15;
            this.button13.Text = "*";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.btn_Operator);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(125, 216);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(49, 51);
            this.button14.TabIndex = 14;
            this.button14.Text = "6";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.btn_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(70, 216);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 51);
            this.button15.TabIndex = 13;
            this.button15.Text = "5";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.btn_Click);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(15, 216);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(49, 51);
            this.button16.TabIndex = 12;
            this.button16.Text = "4";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.btn_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(180, 273);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(49, 51);
            this.button17.TabIndex = 19;
            this.button17.Text = "-";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.btn_Operator);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.Location = new System.Drawing.Point(125, 273);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(49, 51);
            this.button18.TabIndex = 18;
            this.button18.Text = "3";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.btn_Click);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.Location = new System.Drawing.Point(70, 273);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(49, 51);
            this.button19.TabIndex = 17;
            this.button19.Text = "2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.btn_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.Location = new System.Drawing.Point(15, 273);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(49, 51);
            this.button20.TabIndex = 16;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.btn_Click);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.Location = new System.Drawing.Point(180, 330);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(49, 51);
            this.button21.TabIndex = 23;
            this.button21.Text = "+";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.btn_Operator);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.Location = new System.Drawing.Point(70, 330);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(49, 51);
            this.button22.TabIndex = 22;
            this.button22.Text = ",";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.btn_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.Location = new System.Drawing.Point(15, 330);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(49, 51);
            this.button24.TabIndex = 20;
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.btn_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.Location = new System.Drawing.Point(125, 330);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(49, 51);
            this.button25.TabIndex = 29;
            this.button25.Text = "=";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.Location = new System.Drawing.Point(125, 102);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(49, 51);
            this.button27.TabIndex = 27;
            this.button27.Text = "C";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.Location = new System.Drawing.Point(70, 102);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(49, 51);
            this.button28.TabIndex = 26;
            this.button28.Text = "CE";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // btn_Invert
            // 
            this.btn_Invert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Invert.Location = new System.Drawing.Point(423, 216);
            this.btn_Invert.Name = "btn_Invert";
            this.btn_Invert.Size = new System.Drawing.Size(49, 51);
            this.btn_Invert.TabIndex = 25;
            this.btn_Invert.Text = "1/x";
            this.btn_Invert.UseVisualStyleBackColor = true;
            this.btn_Invert.Click += new System.EventHandler(this.btn_Invert_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(15, 64);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(214, 29);
            this.result.TabIndex = 30;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Eq
            // 
            this.lbl_Eq.AutoSize = true;
            this.lbl_Eq.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_Eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Eq.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Eq.Location = new System.Drawing.Point(18, 67);
            this.lbl_Eq.Name = "lbl_Eq";
            this.lbl_Eq.Size = new System.Drawing.Size(0, 20);
            this.lbl_Eq.TabIndex = 31;
            // 
            // btn_BckSpace
            // 
            this.btn_BckSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BckSpace.Location = new System.Drawing.Point(15, 102);
            this.btn_BckSpace.Name = "btn_BckSpace";
            this.btn_BckSpace.Size = new System.Drawing.Size(49, 51);
            this.btn_BckSpace.TabIndex = 32;
            this.btn_BckSpace.Text = "⌫ ";
            this.btn_BckSpace.UseVisualStyleBackColor = true;
            this.btn_BckSpace.Click += new System.EventHandler(this.btn_BckSpace_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 51);
            this.button1.TabIndex = 33;
            this.button1.Text = "ln x";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(423, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 51);
            this.button2.TabIndex = 34;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(367, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 51);
            this.button3.TabIndex = 38;
            this.button3.Text = "Oct";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(367, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 51);
            this.button4.TabIndex = 37;
            this.button4.Text = "Hex";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(367, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 51);
            this.button5.TabIndex = 36;
            this.button5.Text = "Bin";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(367, 159);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(49, 51);
            this.button6.TabIndex = 35;
            this.button6.Text = "Dec";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(310, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 51);
            this.button7.TabIndex = 43;
            this.button7.Text = "Mod";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(310, 273);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(49, 51);
            this.button8.TabIndex = 42;
            this.button8.Text = "Tan";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.Location = new System.Drawing.Point(310, 216);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(49, 51);
            this.button23.TabIndex = 41;
            this.button23.Text = "Cos";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.Location = new System.Drawing.Point(310, 159);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(49, 51);
            this.button26.TabIndex = 40;
            this.button26.Text = "Sin";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.Location = new System.Drawing.Point(310, 102);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(49, 51);
            this.button29.TabIndex = 39;
            this.button29.Text = "Log";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.Location = new System.Drawing.Point(254, 329);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(49, 51);
            this.button30.TabIndex = 48;
            this.button30.Text = "Exp";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button31
            // 
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.Location = new System.Drawing.Point(254, 272);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(49, 51);
            this.button31.TabIndex = 47;
            this.button31.Text = "Tan h";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // button32
            // 
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.Location = new System.Drawing.Point(254, 215);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(49, 51);
            this.button32.TabIndex = 46;
            this.button32.Text = "Cos h";
            this.button32.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.Location = new System.Drawing.Point(254, 158);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(49, 51);
            this.button33.TabIndex = 45;
            this.button33.Text = "Sin h";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.Location = new System.Drawing.Point(254, 101);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(49, 51);
            this.button34.TabIndex = 44;
            this.button34.Text = "𝞹";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.unitConversionToolStripMenuItem,
            this.tabuadaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "Calc";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // unitConversionToolStripMenuItem
            // 
            this.unitConversionToolStripMenuItem.Name = "unitConversionToolStripMenuItem";
            this.unitConversionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unitConversionToolStripMenuItem.Text = "Unit Conversion";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.tabuadaToolStripMenuItem.Text = "Tabuada";
            // 
            // form_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 387);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button33);
            this.Controls.Add(this.button34);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_BckSpace);
            this.Controls.Add(this.lbl_Eq);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.btn_Invert);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btn_InvertSign);
            this.Controls.Add(this.btn_Cube);
            this.Controls.Add(this.btn_Sqr);
            this.Controls.Add(this.btn_SqrRoot);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 430);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 430);
            this.Name = "form_Calc";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.form_Calc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_InvertSign;
        private System.Windows.Forms.Button btn_Cube;
        private System.Windows.Forms.Button btn_Sqr;
        private System.Windows.Forms.Button btn_SqrRoot;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button btn_Invert;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label lbl_Eq;
        private System.Windows.Forms.Button btn_BckSpace;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
    }
}


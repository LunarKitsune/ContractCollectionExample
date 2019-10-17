namespace Contract_Collection_Example
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDInput = new System.Windows.Forms.TextBox();
            this.txtIDFind = new System.Windows.Forms.TextBox();
            this.txtClientAmount = new System.Windows.Forms.TextBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnRemoveContract = new System.Windows.Forms.Button();
            this.btnDisplayCurrent = new System.Windows.Forms.Button();
            this.btnTotalDisplay = new System.Windows.Forms.Button();
            this.btnIDSearch = new System.Windows.Forms.Button();
            this.rtbOutputBox = new System.Windows.Forms.RichTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.errprovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contract ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contract Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Find:";
            // 
            // txtIDInput
            // 
            this.txtIDInput.Location = new System.Drawing.Point(136, 43);
            this.txtIDInput.Name = "txtIDInput";
            this.txtIDInput.Size = new System.Drawing.Size(76, 20);
            this.txtIDInput.TabIndex = 4;
            this.txtIDInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCheckID_KeyDown);
            this.txtIDInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountKeyPress);
            // 
            // txtIDFind
            // 
            this.txtIDFind.Location = new System.Drawing.Point(136, 190);
            this.txtIDFind.Name = "txtIDFind";
            this.txtIDFind.Size = new System.Drawing.Size(76, 20);
            this.txtIDFind.TabIndex = 5;
            // 
            // txtClientAmount
            // 
            this.txtClientAmount.Location = new System.Drawing.Point(136, 137);
            this.txtClientAmount.Name = "txtClientAmount";
            this.txtClientAmount.Size = new System.Drawing.Size(76, 20);
            this.txtClientAmount.TabIndex = 6;
            this.txtClientAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyEventDetection_AsciiVer);
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(136, 92);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(76, 20);
            this.txtNameInput.TabIndex = 7;
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(24, 237);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(75, 23);
            this.btnAddContract.TabIndex = 8;
            this.btnAddContract.Text = "Add";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // btnRemoveContract
            // 
            this.btnRemoveContract.Location = new System.Drawing.Point(136, 237);
            this.btnRemoveContract.Name = "btnRemoveContract";
            this.btnRemoveContract.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveContract.TabIndex = 9;
            this.btnRemoveContract.Text = "Remove";
            this.btnRemoveContract.UseVisualStyleBackColor = true;
            this.btnRemoveContract.Click += new System.EventHandler(this.btnRemoveContract_Click);
            // 
            // btnDisplayCurrent
            // 
            this.btnDisplayCurrent.Location = new System.Drawing.Point(24, 284);
            this.btnDisplayCurrent.Name = "btnDisplayCurrent";
            this.btnDisplayCurrent.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayCurrent.TabIndex = 10;
            this.btnDisplayCurrent.Text = "Display";
            this.btnDisplayCurrent.UseVisualStyleBackColor = true;
            this.btnDisplayCurrent.Click += new System.EventHandler(this.btnDisplayCurrent_Click);
            // 
            // btnTotalDisplay
            // 
            this.btnTotalDisplay.Location = new System.Drawing.Point(249, 237);
            this.btnTotalDisplay.Name = "btnTotalDisplay";
            this.btnTotalDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnTotalDisplay.TabIndex = 11;
            this.btnTotalDisplay.Text = "Total Amount";
            this.btnTotalDisplay.UseVisualStyleBackColor = true;
            this.btnTotalDisplay.Click += new System.EventHandler(this.btnTotalDisplay_Click);
            // 
            // btnIDSearch
            // 
            this.btnIDSearch.Location = new System.Drawing.Point(136, 284);
            this.btnIDSearch.Name = "btnIDSearch";
            this.btnIDSearch.Size = new System.Drawing.Size(75, 23);
            this.btnIDSearch.TabIndex = 12;
            this.btnIDSearch.Text = "Find ID";
            this.btnIDSearch.UseVisualStyleBackColor = true;
            this.btnIDSearch.Click += new System.EventHandler(this.btnIDSearch_Click);
            // 
            // rtbOutputBox
            // 
            this.rtbOutputBox.Location = new System.Drawing.Point(240, 43);
            this.rtbOutputBox.Name = "rtbOutputBox";
            this.rtbOutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbOutputBox.Size = new System.Drawing.Size(199, 167);
            this.rtbOutputBox.TabIndex = 13;
            this.rtbOutputBox.Text = "";
            this.rtbOutputBox.TextChanged += new System.EventHandler(this.rtbOutputBox_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(249, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errprovider
            // 
            this.errprovider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rtbOutputBox);
            this.Controls.Add(this.btnIDSearch);
            this.Controls.Add(this.btnTotalDisplay);
            this.Controls.Add(this.btnDisplayCurrent);
            this.Controls.Add(this.btnRemoveContract);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.txtClientAmount);
            this.Controls.Add(this.txtIDFind);
            this.Controls.Add(this.txtIDInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contract Collections";
            ((System.ComponentModel.ISupportInitialize)(this.errprovider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDInput;
        private System.Windows.Forms.TextBox txtIDFind;
        private System.Windows.Forms.TextBox txtClientAmount;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnRemoveContract;
        private System.Windows.Forms.Button btnDisplayCurrent;
        private System.Windows.Forms.Button btnTotalDisplay;
        private System.Windows.Forms.Button btnIDSearch;
        private System.Windows.Forms.RichTextBox rtbOutputBox;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errprovider;
    }
}


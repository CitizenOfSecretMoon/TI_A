namespace lab_1
{
    partial class frmMain
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
            this.cmbCipherTypes = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txbData = new System.Windows.Forms.TextBox();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.rbEncrypt = new System.Windows.Forms.RadioButton();
            this.rbDecrypt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbCipherTypes
            // 
            this.cmbCipherTypes.FormattingEnabled = true;
            this.cmbCipherTypes.Items.AddRange(new object[] {
            "Железнодорожная изгородь",
            "Столбцовый метод",
            "Переворачиващаяся решётка",
            "Шифр виженера (англ.)"});
            this.cmbCipherTypes.Location = new System.Drawing.Point(13, 13);
            this.cmbCipherTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCipherTypes.Name = "cmbCipherTypes";
            this.cmbCipherTypes.Size = new System.Drawing.Size(246, 30);
            this.cmbCipherTypes.TabIndex = 0;
            this.cmbCipherTypes.Text = "Выберите тип шифровки";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(31, 80);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(130, 22);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Введите текст";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(31, 173);
            this.lblKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(263, 22);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Введите ключ(на английском)";
            // 
            // txbData
            // 
            this.txbData.Location = new System.Drawing.Point(35, 121);
            this.txbData.Margin = new System.Windows.Forms.Padding(4);
            this.txbData.Name = "txbData";
            this.txbData.Size = new System.Drawing.Size(567, 28);
            this.txbData.TabIndex = 3;
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(35, 212);
            this.txbKey.Margin = new System.Windows.Forms.Padding(4);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(567, 28);
            this.txbKey.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(276, 286);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 43);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Выполнить";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(31, 354);
            this.lblRes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(95, 22);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Результат";
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(35, 380);
            this.txbResult.Margin = new System.Windows.Forms.Padding(4);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(567, 28);
            this.txbResult.TabIndex = 7;
            // 
            // rbEncrypt
            // 
            this.rbEncrypt.AutoSize = true;
            this.rbEncrypt.Location = new System.Drawing.Point(276, 14);
            this.rbEncrypt.Name = "rbEncrypt";
            this.rbEncrypt.Size = new System.Drawing.Size(144, 26);
            this.rbEncrypt.TabIndex = 10;
            this.rbEncrypt.TabStop = true;
            this.rbEncrypt.Text = "Шифрование";
            this.rbEncrypt.UseVisualStyleBackColor = true;
            // 
            // rbDecrypt
            // 
            this.rbDecrypt.AutoSize = true;
            this.rbDecrypt.Location = new System.Drawing.Point(435, 14);
            this.rbDecrypt.Name = "rbDecrypt";
            this.rbDecrypt.Size = new System.Drawing.Size(167, 26);
            this.rbDecrypt.TabIndex = 11;
            this.rbDecrypt.TabStop = true;
            this.rbDecrypt.Text = "Дешифрование";
            this.rbDecrypt.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 480);
            this.Controls.Add(this.rbDecrypt);
            this.Controls.Add(this.rbEncrypt);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.txbData);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.cmbCipherTypes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Simple ciphers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCipherTypes;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txbData;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.RadioButton rbEncrypt;
        private System.Windows.Forms.RadioButton rbDecrypt;
    }
}


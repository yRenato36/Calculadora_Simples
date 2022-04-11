namespace Calculadora_Simples
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.textResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.btSoma = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btPonto = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.textResultado.Location = new System.Drawing.Point(26, 18);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(304, 35);
            this.textResultado.TabIndex = 0;
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textResultado.TextChanged += new System.EventHandler(this.textResultado_TextChanged);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.Color.White;
            this.lblOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblOperacao.Location = new System.Drawing.Point(45, 22);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 29);
            this.lblOperacao.TabIndex = 1;
            this.lblOperacao.Click += new System.EventHandler(this.lblOperacao_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.ForeColor = System.Drawing.Color.Black;
            this.bt7.Location = new System.Drawing.Point(26, 59);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(56, 60);
            this.bt7.TabIndex = 2;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.ForeColor = System.Drawing.Color.Black;
            this.bt8.Location = new System.Drawing.Point(88, 59);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(56, 60);
            this.bt8.TabIndex = 3;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // btSoma
            // 
            this.btSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btSoma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSoma.ForeColor = System.Drawing.Color.Black;
            this.btSoma.Location = new System.Drawing.Point(212, 61);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(56, 60);
            this.btSoma.TabIndex = 5;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = false;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.ForeColor = System.Drawing.Color.Black;
            this.bt9.Location = new System.Drawing.Point(150, 61);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(56, 60);
            this.bt9.TabIndex = 4;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btCE
            // 
            this.btCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.ForeColor = System.Drawing.Color.Black;
            this.btCE.Location = new System.Drawing.Point(274, 61);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(56, 60);
            this.btCE.TabIndex = 6;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = false;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btC
            // 
            this.btC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.ForeColor = System.Drawing.Color.Black;
            this.btC.Location = new System.Drawing.Point(274, 127);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(56, 60);
            this.btC.TabIndex = 11;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = false;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSub.ForeColor = System.Drawing.Color.Black;
            this.btSub.Location = new System.Drawing.Point(212, 127);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(56, 60);
            this.btSub.TabIndex = 10;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.ForeColor = System.Drawing.Color.Black;
            this.bt6.Location = new System.Drawing.Point(150, 127);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(56, 60);
            this.bt6.TabIndex = 9;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.ForeColor = System.Drawing.Color.Black;
            this.bt5.Location = new System.Drawing.Point(88, 127);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(56, 60);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.ForeColor = System.Drawing.Color.Black;
            this.bt4.Location = new System.Drawing.Point(26, 127);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(56, 60);
            this.bt4.TabIndex = 7;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiv.ForeColor = System.Drawing.Color.Black;
            this.btDiv.Location = new System.Drawing.Point(212, 259);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(56, 60);
            this.btDiv.TabIndex = 20;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btPonto
            // 
            this.btPonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPonto.ForeColor = System.Drawing.Color.Black;
            this.btPonto.Location = new System.Drawing.Point(150, 259);
            this.btPonto.Name = "btPonto";
            this.btPonto.Size = new System.Drawing.Size(56, 60);
            this.btPonto.TabIndex = 19;
            this.btPonto.Text = ".";
            this.btPonto.UseVisualStyleBackColor = false;
            this.btPonto.Click += new System.EventHandler(this.btPonto_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.ForeColor = System.Drawing.Color.Black;
            this.bt0.Location = new System.Drawing.Point(26, 259);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(118, 60);
            this.bt0.TabIndex = 17;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(148)))), ((int)(((byte)(35)))));
            this.btIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.ForeColor = System.Drawing.Color.Black;
            this.btIgual.Location = new System.Drawing.Point(274, 193);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(56, 126);
            this.btIgual.TabIndex = 16;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // btMult
            // 
            this.btMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.btMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMult.ForeColor = System.Drawing.Color.Black;
            this.btMult.Location = new System.Drawing.Point(212, 193);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(56, 60);
            this.btMult.TabIndex = 15;
            this.btMult.Text = "x";
            this.btMult.UseVisualStyleBackColor = false;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.ForeColor = System.Drawing.Color.Black;
            this.bt3.Location = new System.Drawing.Point(150, 193);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(56, 60);
            this.bt3.TabIndex = 14;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.ForeColor = System.Drawing.Color.Black;
            this.bt2.Location = new System.Drawing.Point(88, 193);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(56, 60);
            this.bt2.TabIndex = 13;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(163)))), ((int)(((byte)(253)))));
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.ForeColor = System.Drawing.Color.Black;
            this.bt1.Location = new System.Drawing.Point(26, 193);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(56, 60);
            this.bt1.TabIndex = 12;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(97)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(356, 337);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btPonto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btSoma);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.textResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btPonto;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
    }
}


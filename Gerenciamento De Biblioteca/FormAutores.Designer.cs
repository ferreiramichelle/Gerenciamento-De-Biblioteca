namespace Gerenciamento_De_Biblioteca
{
    partial class FormAutores
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
            label1 = new Label();
            txtNome = new TextBox();
            txtNascionalidade = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDataNascimento = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 90);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(199, 23);
            txtNome.TabIndex = 1;
            // 
            // txtNascionalidade
            // 
            txtNascionalidade.Location = new Point(50, 185);
            txtNascionalidade.Name = "txtNascionalidade";
            txtNascionalidade.Size = new Size(199, 23);
            txtNascionalidade.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 167);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Nascionalidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 69);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento";
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(300, 87);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(350, 185);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 6;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 243);
            Controls.Add(button1);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNascionalidade);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "FormAutores";
            Text = "FormAutores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtNascionalidade;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDataNascimento;
        private Button button1;
    }
}
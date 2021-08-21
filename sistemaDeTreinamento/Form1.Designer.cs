
namespace sistemaDeTreinamento
{
    partial class Form1
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.buttonTabPerfil = new System.Windows.Forms.Button();
            this.buttonTabConfiguracoes = new System.Windows.Forms.Button();
            this.buttonTabMeusCursos = new System.Windows.Forms.Button();
            this.buttonTabCursos = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTituloPrincipal = new System.Windows.Forms.Label();
            this.panelNavigation.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelNavigation.Controls.Add(this.buttonTabPerfil);
            this.panelNavigation.Controls.Add(this.buttonTabConfiguracoes);
            this.panelNavigation.Controls.Add(this.buttonTabMeusCursos);
            this.panelNavigation.Controls.Add(this.buttonTabCursos);
            this.panelNavigation.Controls.Add(this.panelLogo);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(132, 450);
            this.panelNavigation.TabIndex = 0;
            // 
            // buttonTabPerfil
            // 
            this.buttonTabPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonTabPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTabPerfil.FlatAppearance.BorderSize = 0;
            this.buttonTabPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabPerfil.ForeColor = System.Drawing.Color.White;
            this.buttonTabPerfil.Image = global::sistemaDeTreinamento.Properties.Resources.perfil_de_usuario;
            this.buttonTabPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabPerfil.Location = new System.Drawing.Point(0, 370);
            this.buttonTabPerfil.Name = "buttonTabPerfil";
            this.buttonTabPerfil.Size = new System.Drawing.Size(132, 40);
            this.buttonTabPerfil.TabIndex = 7;
            this.buttonTabPerfil.Text = "Meu Perfil";
            this.buttonTabPerfil.UseVisualStyleBackColor = false;
            this.buttonTabPerfil.Click += new System.EventHandler(this.buttonTabPerfil_Click);
            // 
            // buttonTabConfiguracoes
            // 
            this.buttonTabConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonTabConfiguracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabConfiguracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonTabConfiguracoes.FlatAppearance.BorderSize = 0;
            this.buttonTabConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.buttonTabConfiguracoes.Image = global::sistemaDeTreinamento.Properties.Resources.configuracoes_da_web;
            this.buttonTabConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabConfiguracoes.Location = new System.Drawing.Point(0, 410);
            this.buttonTabConfiguracoes.Name = "buttonTabConfiguracoes";
            this.buttonTabConfiguracoes.Size = new System.Drawing.Size(132, 40);
            this.buttonTabConfiguracoes.TabIndex = 6;
            this.buttonTabConfiguracoes.Text = "Configurações";
            this.buttonTabConfiguracoes.UseVisualStyleBackColor = false;
            this.buttonTabConfiguracoes.Click += new System.EventHandler(this.buttonTabConfiguracoes_Click);
            // 
            // buttonTabMeusCursos
            // 
            this.buttonTabMeusCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonTabMeusCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabMeusCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTabMeusCursos.FlatAppearance.BorderSize = 0;
            this.buttonTabMeusCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabMeusCursos.ForeColor = System.Drawing.Color.White;
            this.buttonTabMeusCursos.Image = global::sistemaDeTreinamento.Properties.Resources.book_1_1;
            this.buttonTabMeusCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabMeusCursos.Location = new System.Drawing.Point(0, 90);
            this.buttonTabMeusCursos.Name = "buttonTabMeusCursos";
            this.buttonTabMeusCursos.Size = new System.Drawing.Size(132, 40);
            this.buttonTabMeusCursos.TabIndex = 4;
            this.buttonTabMeusCursos.Text = "Meus Cursos";
            this.buttonTabMeusCursos.UseVisualStyleBackColor = false;
            this.buttonTabMeusCursos.Click += new System.EventHandler(this.buttonTabMeusCursos_Click);
            // 
            // buttonTabCursos
            // 
            this.buttonTabCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonTabCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTabCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTabCursos.FlatAppearance.BorderSize = 0;
            this.buttonTabCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabCursos.ForeColor = System.Drawing.Color.White;
            this.buttonTabCursos.Image = global::sistemaDeTreinamento.Properties.Resources.my_business;
            this.buttonTabCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTabCursos.Location = new System.Drawing.Point(0, 50);
            this.buttonTabCursos.Name = "buttonTabCursos";
            this.buttonTabCursos.Size = new System.Drawing.Size(132, 40);
            this.buttonTabCursos.TabIndex = 2;
            this.buttonTabCursos.Text = "Cursos";
            this.buttonTabCursos.UseVisualStyleBackColor = false;
            this.buttonTabCursos.Click += new System.EventHandler(this.buttonTabCursos_Click);
            this.buttonTabCursos.MouseEnter += new System.EventHandler(this.buttonTabCursos_MouseEnter);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panelLogo.Controls.Add(this.buttonLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(132, 50);
            this.panelLogo.TabIndex = 1;
            // 
            // buttonLogo
            // 
            this.buttonLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.buttonLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogo.Image = global::sistemaDeTreinamento.Properties.Resources.curso_online;
            this.buttonLogo.Location = new System.Drawing.Point(0, 0);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(132, 50);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.UseVisualStyleBackColor = false;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.labelTituloPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 50);
            this.panel1.TabIndex = 1;
            // 
            // labelTituloPrincipal
            // 
            this.labelTituloPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTituloPrincipal.AutoSize = true;
            this.labelTituloPrincipal.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPrincipal.ForeColor = System.Drawing.Color.White;
            this.labelTituloPrincipal.Location = new System.Drawing.Point(285, 9);
            this.labelTituloPrincipal.Name = "labelTituloPrincipal";
            this.labelTituloPrincipal.Size = new System.Drawing.Size(98, 36);
            this.labelTituloPrincipal.TabIndex = 0;
            this.labelTituloPrincipal.Text = "Home";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNavigation);
            this.Name = "Form1";
            this.Text = "Cursos Techstar";
            this.panelNavigation.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button buttonTabCursos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonTabConfiguracoes;
        private System.Windows.Forms.Button buttonTabMeusCursos;
        private System.Windows.Forms.Button buttonTabPerfil;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTituloPrincipal;
    }
}


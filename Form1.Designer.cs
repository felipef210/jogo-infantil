namespace Jogo_3
{
    partial class Frm_Jogo3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Jogo3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Erros = new System.Windows.Forms.Label();
            this.Lbl_Acertos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Iniciar = new System.Windows.Forms.Button();
            this.Btn_Reiniciar = new System.Windows.Forms.Button();
            this.Btn_Autores = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pbx_Pergunta = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_Tempo = new System.Windows.Forms.Label();
            this.Media_Pergunta = new AxWMPLib.AxWindowsMediaPlayer();
            this.Pbx_Chapeu1 = new System.Windows.Forms.PictureBox();
            this.Pbx_Abobora1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Pbx_Nao = new System.Windows.Forms.PictureBox();
            this.Media_Nao = new AxWMPLib.AxWindowsMediaPlayer();
            this.Pbx_Sim = new System.Windows.Forms.PictureBox();
            this.Media_Sim = new AxWMPLib.AxWindowsMediaPlayer();
            this.Btn_Nao = new System.Windows.Forms.Button();
            this.Btn_Sim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Media_Iniciar = new AxWMPLib.AxWindowsMediaPlayer();
            this.Media_Reiniciar = new AxWMPLib.AxWindowsMediaPlayer();
            this.Media_Autores = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pbx_Iniciar = new System.Windows.Forms.PictureBox();
            this.Pbx_Reiniciar = new System.Windows.Forms.PictureBox();
            this.Pbx_Autores = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Pergunta)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Pergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Chapeu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Abobora1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Nao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Nao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Sim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Reiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Autores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Iniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Reiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Autores)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Jogo_3.Properties.Resources.vkcontpng;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(672, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Lbl_Erros);
            this.panel2.Controls.Add(this.Lbl_Acertos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(540, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 99);
            this.panel2.TabIndex = 2;
            // 
            // Lbl_Erros
            // 
            this.Lbl_Erros.AutoSize = true;
            this.Lbl_Erros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Erros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Erros.Location = new System.Drawing.Point(65, 50);
            this.Lbl_Erros.Name = "Lbl_Erros";
            this.Lbl_Erros.Size = new System.Drawing.Size(23, 25);
            this.Lbl_Erros.TabIndex = 3;
            this.Lbl_Erros.Text = "0";
            // 
            // Lbl_Acertos
            // 
            this.Lbl_Acertos.AutoSize = true;
            this.Lbl_Acertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Acertos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Acertos.Location = new System.Drawing.Point(82, 9);
            this.Lbl_Acertos.Name = "Lbl_Acertos";
            this.Lbl_Acertos.Size = new System.Drawing.Size(23, 25);
            this.Lbl_Acertos.TabIndex = 2;
            this.Lbl_Acertos.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Erros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acertos:";
            // 
            // Btn_Iniciar
            // 
            this.Btn_Iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.Btn_Iniciar.Image = global::Jogo_3.Properties.Resources.iniciarReal;
            this.Btn_Iniciar.Location = new System.Drawing.Point(540, 224);
            this.Btn_Iniciar.Name = "Btn_Iniciar";
            this.Btn_Iniciar.Size = new System.Drawing.Size(153, 49);
            this.Btn_Iniciar.TabIndex = 3;
            this.Btn_Iniciar.UseVisualStyleBackColor = false;
            this.Btn_Iniciar.Click += new System.EventHandler(this.Btn_Iniciar_Click);
            // 
            // Btn_Reiniciar
            // 
            this.Btn_Reiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.Btn_Reiniciar.Image = global::Jogo_3.Properties.Resources.reiniciar2;
            this.Btn_Reiniciar.Location = new System.Drawing.Point(541, 279);
            this.Btn_Reiniciar.Name = "Btn_Reiniciar";
            this.Btn_Reiniciar.Size = new System.Drawing.Size(153, 49);
            this.Btn_Reiniciar.TabIndex = 4;
            this.Btn_Reiniciar.UseVisualStyleBackColor = false;
            this.Btn_Reiniciar.Click += new System.EventHandler(this.Btn_Reiniciar_Click);
            // 
            // Btn_Autores
            // 
            this.Btn_Autores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.Btn_Autores.Image = global::Jogo_3.Properties.Resources.autores2;
            this.Btn_Autores.Location = new System.Drawing.Point(541, 334);
            this.Btn_Autores.Name = "Btn_Autores";
            this.Btn_Autores.Size = new System.Drawing.Size(153, 49);
            this.Btn_Autores.TabIndex = 5;
            this.Btn_Autores.UseVisualStyleBackColor = false;
            this.Btn_Autores.Click += new System.EventHandler(this.Btn_Autores_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Pbx_Pergunta);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Media_Pergunta);
            this.panel1.Controls.Add(this.Pbx_Chapeu1);
            this.panel1.Controls.Add(this.Pbx_Abobora1);
            this.panel1.Controls.Add(this.Lbl_Pergunta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 264);
            this.panel1.TabIndex = 6;
            // 
            // Pbx_Pergunta
            // 
            this.Pbx_Pergunta.Image = global::Jogo_3.Properties.Resources.audio2;
            this.Pbx_Pergunta.Location = new System.Drawing.Point(27, 8);
            this.Pbx_Pergunta.Name = "Pbx_Pergunta";
            this.Pbx_Pergunta.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Pergunta.TabIndex = 10;
            this.Pbx_Pergunta.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.Lbl_Tempo);
            this.panel4.Location = new System.Drawing.Point(341, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(131, 71);
            this.panel4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(24, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(51, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seg";
            // 
            // Lbl_Tempo
            // 
            this.Lbl_Tempo.AutoSize = true;
            this.Lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Tempo.Location = new System.Drawing.Point(25, 37);
            this.Lbl_Tempo.Name = "Lbl_Tempo";
            this.Lbl_Tempo.Size = new System.Drawing.Size(30, 24);
            this.Lbl_Tempo.TabIndex = 7;
            this.Lbl_Tempo.Text = "10";
            // 
            // Media_Pergunta
            // 
            this.Media_Pergunta.Enabled = true;
            this.Media_Pergunta.Location = new System.Drawing.Point(27, 8);
            this.Media_Pergunta.Name = "Media_Pergunta";
            this.Media_Pergunta.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Pergunta.OcxState")));
            this.Media_Pergunta.Size = new System.Drawing.Size(32, 32);
            this.Media_Pergunta.TabIndex = 6;
            this.Media_Pergunta.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Media_Pergunta_ClickEvent);
            // 
            // Pbx_Chapeu1
            // 
            this.Pbx_Chapeu1.Location = new System.Drawing.Point(3, 137);
            this.Pbx_Chapeu1.Name = "Pbx_Chapeu1";
            this.Pbx_Chapeu1.Size = new System.Drawing.Size(332, 78);
            this.Pbx_Chapeu1.TabIndex = 5;
            this.Pbx_Chapeu1.TabStop = false;
            // 
            // Pbx_Abobora1
            // 
            this.Pbx_Abobora1.Location = new System.Drawing.Point(3, 55);
            this.Pbx_Abobora1.Name = "Pbx_Abobora1";
            this.Pbx_Abobora1.Size = new System.Drawing.Size(332, 78);
            this.Pbx_Abobora1.TabIndex = 2;
            this.Pbx_Abobora1.TabStop = false;
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lbl_Pergunta.Location = new System.Drawing.Point(65, 8);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(0, 24);
            this.Lbl_Pergunta.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Pbx_Nao);
            this.panel3.Controls.Add(this.Media_Nao);
            this.panel3.Controls.Add(this.Pbx_Sim);
            this.panel3.Controls.Add(this.Media_Sim);
            this.panel3.Controls.Add(this.Btn_Nao);
            this.panel3.Controls.Add(this.Btn_Sim);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(341, 137);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 120);
            this.panel3.TabIndex = 0;
            // 
            // Pbx_Nao
            // 
            this.Pbx_Nao.Image = global::Jogo_3.Properties.Resources.audio1;
            this.Pbx_Nao.Location = new System.Drawing.Point(3, 69);
            this.Pbx_Nao.Name = "Pbx_Nao";
            this.Pbx_Nao.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Nao.TabIndex = 15;
            this.Pbx_Nao.TabStop = false;
            this.Pbx_Nao.Click += new System.EventHandler(this.Pbx_Nao_Click);
            // 
            // Media_Nao
            // 
            this.Media_Nao.Enabled = true;
            this.Media_Nao.Location = new System.Drawing.Point(3, 69);
            this.Media_Nao.Name = "Media_Nao";
            this.Media_Nao.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Nao.OcxState")));
            this.Media_Nao.Size = new System.Drawing.Size(32, 32);
            this.Media_Nao.TabIndex = 11;
            // 
            // Pbx_Sim
            // 
            this.Pbx_Sim.Image = global::Jogo_3.Properties.Resources.audio1;
            this.Pbx_Sim.Location = new System.Drawing.Point(3, 29);
            this.Pbx_Sim.Name = "Pbx_Sim";
            this.Pbx_Sim.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Sim.TabIndex = 14;
            this.Pbx_Sim.TabStop = false;
            this.Pbx_Sim.Click += new System.EventHandler(this.Pbx_Sim_Click);
            // 
            // Media_Sim
            // 
            this.Media_Sim.Enabled = true;
            this.Media_Sim.Location = new System.Drawing.Point(3, 29);
            this.Media_Sim.Name = "Media_Sim";
            this.Media_Sim.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Sim.OcxState")));
            this.Media_Sim.Size = new System.Drawing.Size(32, 32);
            this.Media_Sim.TabIndex = 10;
            // 
            // Btn_Nao
            // 
            this.Btn_Nao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.Btn_Nao.Image = global::Jogo_3.Properties.Resources.nao;
            this.Btn_Nao.Location = new System.Drawing.Point(40, 67);
            this.Btn_Nao.Name = "Btn_Nao";
            this.Btn_Nao.Size = new System.Drawing.Size(65, 34);
            this.Btn_Nao.TabIndex = 6;
            this.Btn_Nao.UseVisualStyleBackColor = false;
            this.Btn_Nao.Click += new System.EventHandler(this.Btn_Nao_Click);
            // 
            // Btn_Sim
            // 
            this.Btn_Sim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.Btn_Sim.Image = global::Jogo_3.Properties.Resources.sim;
            this.Btn_Sim.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Sim.Location = new System.Drawing.Point(40, 26);
            this.Btn_Sim.Name = "Btn_Sim";
            this.Btn_Sim.Size = new System.Drawing.Size(65, 34);
            this.Btn_Sim.TabIndex = 5;
            this.Btn_Sim.UseVisualStyleBackColor = false;
            this.Btn_Sim.Click += new System.EventHandler(this.Btn_Sim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(24, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resposta:";
            // 
            // Media_Iniciar
            // 
            this.Media_Iniciar.Enabled = true;
            this.Media_Iniciar.Location = new System.Drawing.Point(503, 234);
            this.Media_Iniciar.Name = "Media_Iniciar";
            this.Media_Iniciar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Iniciar.OcxState")));
            this.Media_Iniciar.Size = new System.Drawing.Size(32, 32);
            this.Media_Iniciar.TabIndex = 7;
            // 
            // Media_Reiniciar
            // 
            this.Media_Reiniciar.Enabled = true;
            this.Media_Reiniciar.Location = new System.Drawing.Point(503, 288);
            this.Media_Reiniciar.Name = "Media_Reiniciar";
            this.Media_Reiniciar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Reiniciar.OcxState")));
            this.Media_Reiniciar.Size = new System.Drawing.Size(32, 32);
            this.Media_Reiniciar.TabIndex = 8;
            // 
            // Media_Autores
            // 
            this.Media_Autores.Enabled = true;
            this.Media_Autores.Location = new System.Drawing.Point(503, 346);
            this.Media_Autores.Name = "Media_Autores";
            this.Media_Autores.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media_Autores.OcxState")));
            this.Media_Autores.Size = new System.Drawing.Size(32, 32);
            this.Media_Autores.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pbx_Iniciar
            // 
            this.Pbx_Iniciar.Image = global::Jogo_3.Properties.Resources.audio1;
            this.Pbx_Iniciar.Location = new System.Drawing.Point(503, 234);
            this.Pbx_Iniciar.Name = "Pbx_Iniciar";
            this.Pbx_Iniciar.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Iniciar.TabIndex = 11;
            this.Pbx_Iniciar.TabStop = false;
            this.Pbx_Iniciar.Click += new System.EventHandler(this.Pbx_Iniciar_Click);
            // 
            // Pbx_Reiniciar
            // 
            this.Pbx_Reiniciar.Image = global::Jogo_3.Properties.Resources.audio1;
            this.Pbx_Reiniciar.Location = new System.Drawing.Point(503, 288);
            this.Pbx_Reiniciar.Name = "Pbx_Reiniciar";
            this.Pbx_Reiniciar.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Reiniciar.TabIndex = 12;
            this.Pbx_Reiniciar.TabStop = false;
            this.Pbx_Reiniciar.Click += new System.EventHandler(this.Pbx_Reiniciar_Click);
            // 
            // Pbx_Autores
            // 
            this.Pbx_Autores.Image = global::Jogo_3.Properties.Resources.audio1;
            this.Pbx_Autores.Location = new System.Drawing.Point(503, 346);
            this.Pbx_Autores.Name = "Pbx_Autores";
            this.Pbx_Autores.Size = new System.Drawing.Size(32, 32);
            this.Pbx_Autores.TabIndex = 13;
            this.Pbx_Autores.TabStop = false;
            this.Pbx_Autores.Click += new System.EventHandler(this.Pbx_Autores_Click);
            // 
            // Frm_Jogo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Jogo_3.Properties.Resources._23a022c24f1074db5e69b04a542f1b6b;
            this.ClientSize = new System.Drawing.Size(696, 511);
            this.Controls.Add(this.Pbx_Autores);
            this.Controls.Add(this.Pbx_Reiniciar);
            this.Controls.Add(this.Pbx_Iniciar);
            this.Controls.Add(this.Media_Autores);
            this.Controls.Add(this.Media_Reiniciar);
            this.Controls.Add(this.Media_Iniciar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_Autores);
            this.Controls.Add(this.Btn_Reiniciar);
            this.Controls.Add(this.Btn_Iniciar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Jogo3";
            this.Text = "Vick Count";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Jogo3_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Jogo3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Pergunta)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Pergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Chapeu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Abobora1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Nao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Nao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Sim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Reiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Media_Autores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Iniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Reiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Autores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Iniciar;
        private System.Windows.Forms.Button Btn_Reiniciar;
        private System.Windows.Forms.Button Btn_Autores;
        private System.Windows.Forms.Label Lbl_Erros;
        private System.Windows.Forms.Label Lbl_Acertos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pbx_Chapeu1;
        private System.Windows.Forms.PictureBox Pbx_Abobora1;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_Nao;
        private System.Windows.Forms.Button Btn_Sim;
        private System.Windows.Forms.Label label5;
        private AxWMPLib.AxWindowsMediaPlayer Media_Iniciar;
        private AxWMPLib.AxWindowsMediaPlayer Media_Reiniciar;
        private AxWMPLib.AxWindowsMediaPlayer Media_Autores;
        private AxWMPLib.AxWindowsMediaPlayer Media_Pergunta;
        private AxWMPLib.AxWindowsMediaPlayer Media_Nao;
        private AxWMPLib.AxWindowsMediaPlayer Media_Sim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_Tempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Pbx_Pergunta;
        private System.Windows.Forms.PictureBox Pbx_Iniciar;
        private System.Windows.Forms.PictureBox Pbx_Reiniciar;
        private System.Windows.Forms.PictureBox Pbx_Autores;
        private System.Windows.Forms.PictureBox Pbx_Nao;
        private System.Windows.Forms.PictureBox Pbx_Sim;
    }
}


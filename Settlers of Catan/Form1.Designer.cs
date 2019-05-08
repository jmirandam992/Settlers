using System.Windows.Forms;

namespace SOCForm
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
            System.Windows.Forms.Panel tradePanel;
            this.playerData = new System.Windows.Forms.Panel();
            this.lmbCntLbl = new System.Windows.Forms.Label();
            this.brkCntLbl = new System.Windows.Forms.Label();
            this.woolCntLbl = new System.Windows.Forms.Label();
            this.oreCntLbl = new System.Windows.Forms.Label();
            this.grnCntLbl = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.settleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grainLbl = new System.Windows.Forms.Label();
            this.oreLbl = new System.Windows.Forms.Label();
            this.woolLbl = new System.Windows.Forms.Label();
            this.brickLbl = new System.Windows.Forms.Label();
            this.lmbrLbl = new System.Windows.Forms.Label();
            this.player2Select = new System.Windows.Forms.Button();
            this.player3Select = new System.Windows.Forms.Button();
            this.player4Select = new System.Windows.Forms.Button();
            this.player1Select = new System.Windows.Forms.Button();
            this.playerDataPnlBtn = new System.Windows.Forms.Button();
            this.endTurnBtn = new System.Windows.Forms.Button();
            this.dieP2 = new System.Windows.Forms.PictureBox();
            this.dieP1 = new System.Windows.Forms.PictureBox();
            this.diceRollBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tradingPanel = new System.Windows.Forms.Panel();
            this.tradeeBrkVlu = new System.Windows.Forms.TextBox();
            this.tradeeWlVlu = new System.Windows.Forms.TextBox();
            this.tradeeOreVlu = new System.Windows.Forms.TextBox();
            this.tradeeGrnVlu = new System.Windows.Forms.TextBox();
            this.tradeeLumberVlu = new System.Windows.Forms.TextBox();
            this.tradeeLumberQty = new System.Windows.Forms.Label();
            this.tradeeBrickQty = new System.Windows.Forms.Label();
            this.tradeeWoolQty = new System.Windows.Forms.Label();
            this.tradeeOreQty = new System.Windows.Forms.Label();
            this.tradeeGrainQty = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.traderBrickOffer = new System.Windows.Forms.TextBox();
            this.traderWoolOffer = new System.Windows.Forms.TextBox();
            this.traderOreOffer = new System.Windows.Forms.TextBox();
            this.traderGrainOffer = new System.Windows.Forms.TextBox();
            this.traderLumbOffer = new System.Windows.Forms.TextBox();
            this.traderLumQty = new System.Windows.Forms.Label();
            this.traderBrickQty = new System.Windows.Forms.Label();
            this.traderWoolQty = new System.Windows.Forms.Label();
            this.traderOreQty = new System.Windows.Forms.Label();
            this.traderGrainQty = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lumberTLabel = new System.Windows.Forms.Label();
            this.tradingPlayerLbl = new System.Windows.Forms.Label();
            this.currentPlayerlbl = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            tradePanel = new System.Windows.Forms.Panel();
            tradePanel.SuspendLayout();
            this.playerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dieP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieP1)).BeginInit();
            this.tradingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tradePanel
            // 
            tradePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            tradePanel.BackColor = System.Drawing.Color.DarkSlateGray;
            tradePanel.Controls.Add(this.playerData);
            tradePanel.Controls.Add(this.tradingPanel);
            tradePanel.Controls.Add(this.player2Select);
            tradePanel.Controls.Add(this.player3Select);
            tradePanel.Controls.Add(this.player4Select);
            tradePanel.Controls.Add(this.player1Select);
            tradePanel.Controls.Add(this.playerDataPnlBtn);
            tradePanel.Controls.Add(this.endTurnBtn);
            tradePanel.Controls.Add(this.dieP2);
            tradePanel.Controls.Add(this.dieP1);
            tradePanel.Controls.Add(this.diceRollBtn);
            tradePanel.Controls.Add(this.label2);
            tradePanel.Location = new System.Drawing.Point(1302, 11);
            tradePanel.Margin = new System.Windows.Forms.Padding(2);
            tradePanel.Name = "tradePanel";
            tradePanel.Size = new System.Drawing.Size(438, 722);
            tradePanel.TabIndex = 1;
            // 
            // playerData
            // 
            this.playerData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playerData.BackColor = System.Drawing.Color.DimGray;
            this.playerData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerData.Controls.Add(this.lmbCntLbl);
            this.playerData.Controls.Add(this.brkCntLbl);
            this.playerData.Controls.Add(this.woolCntLbl);
            this.playerData.Controls.Add(this.oreCntLbl);
            this.playerData.Controls.Add(this.grnCntLbl);
            this.playerData.Controls.Add(this.label20);
            this.playerData.Controls.Add(this.label18);
            this.playerData.Controls.Add(this.label19);
            this.playerData.Controls.Add(this.cityLbl);
            this.playerData.Controls.Add(this.settleLabel);
            this.playerData.Controls.Add(this.label1);
            this.playerData.Controls.Add(this.grainLbl);
            this.playerData.Controls.Add(this.oreLbl);
            this.playerData.Controls.Add(this.woolLbl);
            this.playerData.Controls.Add(this.brickLbl);
            this.playerData.Controls.Add(this.lmbrLbl);
            this.playerData.Location = new System.Drawing.Point(12, 549);
            this.playerData.Name = "playerData";
            this.playerData.Size = new System.Drawing.Size(418, 155);
            this.playerData.TabIndex = 35;
            // 
            // lmbCntLbl
            // 
            this.lmbCntLbl.BackColor = System.Drawing.Color.Cornsilk;
            this.lmbCntLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lmbCntLbl.Location = new System.Drawing.Point(64, 18);
            this.lmbCntLbl.Name = "lmbCntLbl";
            this.lmbCntLbl.Size = new System.Drawing.Size(39, 23);
            this.lmbCntLbl.TabIndex = 22;
            this.lmbCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // brkCntLbl
            // 
            this.brkCntLbl.BackColor = System.Drawing.Color.Cornsilk;
            this.brkCntLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brkCntLbl.Location = new System.Drawing.Point(125, 18);
            this.brkCntLbl.Name = "brkCntLbl";
            this.brkCntLbl.Size = new System.Drawing.Size(39, 23);
            this.brkCntLbl.TabIndex = 21;
            this.brkCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // woolCntLbl
            // 
            this.woolCntLbl.BackColor = System.Drawing.Color.Cornsilk;
            this.woolCntLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.woolCntLbl.Location = new System.Drawing.Point(187, 18);
            this.woolCntLbl.Name = "woolCntLbl";
            this.woolCntLbl.Size = new System.Drawing.Size(39, 23);
            this.woolCntLbl.TabIndex = 20;
            this.woolCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oreCntLbl
            // 
            this.oreCntLbl.BackColor = System.Drawing.Color.Cornsilk;
            this.oreCntLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oreCntLbl.Location = new System.Drawing.Point(249, 18);
            this.oreCntLbl.Name = "oreCntLbl";
            this.oreCntLbl.Size = new System.Drawing.Size(39, 23);
            this.oreCntLbl.TabIndex = 19;
            this.oreCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grnCntLbl
            // 
            this.grnCntLbl.BackColor = System.Drawing.Color.Cornsilk;
            this.grnCntLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grnCntLbl.Location = new System.Drawing.Point(311, 18);
            this.grnCntLbl.Name = "grnCntLbl";
            this.grnCntLbl.Size = new System.Drawing.Size(39, 23);
            this.grnCntLbl.TabIndex = 18;
            this.grnCntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Cornsilk;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(104, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 23);
            this.label20.TabIndex = 17;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Cornsilk;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(200, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 23);
            this.label18.TabIndex = 16;
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Cornsilk;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(296, 83);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 23);
            this.label19.TabIndex = 15;
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(107, 119);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(32, 13);
            this.cityLbl.TabIndex = 7;
            this.cityLbl.Text = "Cities";
            // 
            // settleLabel
            // 
            this.settleLabel.AutoSize = true;
            this.settleLabel.Location = new System.Drawing.Point(284, 119);
            this.settleLabel.Name = "settleLabel";
            this.settleLabel.Size = new System.Drawing.Size(62, 13);
            this.settleLabel.TabIndex = 6;
            this.settleLabel.Text = "Settlements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Roads";
            // 
            // grainLbl
            // 
            this.grainLbl.AutoSize = true;
            this.grainLbl.Location = new System.Drawing.Point(318, 50);
            this.grainLbl.Name = "grainLbl";
            this.grainLbl.Size = new System.Drawing.Size(32, 13);
            this.grainLbl.TabIndex = 4;
            this.grainLbl.Text = "Grain";
            // 
            // oreLbl
            // 
            this.oreLbl.AutoSize = true;
            this.oreLbl.Location = new System.Drawing.Point(260, 50);
            this.oreLbl.Name = "oreLbl";
            this.oreLbl.Size = new System.Drawing.Size(24, 13);
            this.oreLbl.TabIndex = 3;
            this.oreLbl.Text = "Ore";
            // 
            // woolLbl
            // 
            this.woolLbl.AutoSize = true;
            this.woolLbl.Location = new System.Drawing.Point(194, 50);
            this.woolLbl.Name = "woolLbl";
            this.woolLbl.Size = new System.Drawing.Size(32, 13);
            this.woolLbl.TabIndex = 2;
            this.woolLbl.Text = "Wool";
            // 
            // brickLbl
            // 
            this.brickLbl.AutoSize = true;
            this.brickLbl.Location = new System.Drawing.Point(130, 50);
            this.brickLbl.Name = "brickLbl";
            this.brickLbl.Size = new System.Drawing.Size(36, 13);
            this.brickLbl.TabIndex = 1;
            this.brickLbl.Text = "Bricks";
            // 
            // lmbrLbl
            // 
            this.lmbrLbl.AutoSize = true;
            this.lmbrLbl.Location = new System.Drawing.Point(65, 50);
            this.lmbrLbl.Name = "lmbrLbl";
            this.lmbrLbl.Size = new System.Drawing.Size(42, 13);
            this.lmbrLbl.TabIndex = 0;
            this.lmbrLbl.Text = "Lumber";
            // 
            // player2Select
            // 
            this.player2Select.Location = new System.Drawing.Point(140, 133);
            this.player2Select.Name = "player2Select";
            this.player2Select.Size = new System.Drawing.Size(75, 23);
            this.player2Select.TabIndex = 43;
            this.player2Select.Text = "Player 2";
            this.player2Select.UseVisualStyleBackColor = true;
            this.player2Select.Click += new System.EventHandler(this.player2Select_Click);
            // 
            // player3Select
            // 
            this.player3Select.Location = new System.Drawing.Point(223, 133);
            this.player3Select.Name = "player3Select";
            this.player3Select.Size = new System.Drawing.Size(75, 23);
            this.player3Select.TabIndex = 42;
            this.player3Select.Text = "Player 3";
            this.player3Select.UseVisualStyleBackColor = true;
            this.player3Select.Click += new System.EventHandler(this.player3Select_Click);
            // 
            // player4Select
            // 
            this.player4Select.Location = new System.Drawing.Point(306, 133);
            this.player4Select.Name = "player4Select";
            this.player4Select.Size = new System.Drawing.Size(75, 23);
            this.player4Select.TabIndex = 41;
            this.player4Select.Text = "Player 4";
            this.player4Select.UseVisualStyleBackColor = true;
            this.player4Select.Click += new System.EventHandler(this.player4Select_Click);
            // 
            // player1Select
            // 
            this.player1Select.Location = new System.Drawing.Point(57, 133);
            this.player1Select.Name = "player1Select";
            this.player1Select.Size = new System.Drawing.Size(75, 23);
            this.player1Select.TabIndex = 40;
            this.player1Select.Text = "Player 1";
            this.player1Select.UseVisualStyleBackColor = true;
            this.player1Select.Click += new System.EventHandler(this.player1Select_Click);
            // 
            // playerDataPnlBtn
            // 
            this.playerDataPnlBtn.Location = new System.Drawing.Point(148, 520);
            this.playerDataPnlBtn.Name = "playerDataPnlBtn";
            this.playerDataPnlBtn.Size = new System.Drawing.Size(142, 23);
            this.playerDataPnlBtn.TabIndex = 39;
            this.playerDataPnlBtn.Text = "Show/Hide Player Data";
            this.playerDataPnlBtn.UseVisualStyleBackColor = true;
            this.playerDataPnlBtn.Click += new System.EventHandler(this.playerDataPnlBtn_Click);
            // 
            // endTurnBtn
            // 
            this.endTurnBtn.Location = new System.Drawing.Point(182, 476);
            this.endTurnBtn.Name = "endTurnBtn";
            this.endTurnBtn.Size = new System.Drawing.Size(75, 23);
            this.endTurnBtn.TabIndex = 38;
            this.endTurnBtn.Text = "End Turn";
            this.endTurnBtn.UseVisualStyleBackColor = true;
            this.endTurnBtn.Click += new System.EventHandler(this.endTurnBtn_Click);
            // 
            // dieP2
            // 
            this.dieP2.Location = new System.Drawing.Point(229, 341);
            this.dieP2.Name = "dieP2";
            this.dieP2.Size = new System.Drawing.Size(100, 100);
            this.dieP2.TabIndex = 37;
            this.dieP2.TabStop = false;
            // 
            // dieP1
            // 
            this.dieP1.Location = new System.Drawing.Point(110, 341);
            this.dieP1.Name = "dieP1";
            this.dieP1.Size = new System.Drawing.Size(100, 100);
            this.dieP1.TabIndex = 36;
            this.dieP1.TabStop = false;
            // 
            // diceRollBtn
            // 
            this.diceRollBtn.Location = new System.Drawing.Point(182, 447);
            this.diceRollBtn.Name = "diceRollBtn";
            this.diceRollBtn.Size = new System.Drawing.Size(75, 23);
            this.diceRollBtn.TabIndex = 35;
            this.diceRollBtn.Text = "Roll Dice";
            this.diceRollBtn.UseVisualStyleBackColor = true;
            this.diceRollBtn.Click += new System.EventHandler(this.diceRollBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FloralWhite;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Select Who to Trade With";
            // 
            // tradingPanel
            // 
            this.tradingPanel.Controls.Add(this.tradeeBrkVlu);
            this.tradingPanel.Controls.Add(this.tradeeWlVlu);
            this.tradingPanel.Controls.Add(this.tradeeOreVlu);
            this.tradingPanel.Controls.Add(this.tradeeGrnVlu);
            this.tradingPanel.Controls.Add(this.tradeeLumberVlu);
            this.tradingPanel.Controls.Add(this.tradeeLumberQty);
            this.tradingPanel.Controls.Add(this.tradeeBrickQty);
            this.tradingPanel.Controls.Add(this.tradeeWoolQty);
            this.tradingPanel.Controls.Add(this.tradeeOreQty);
            this.tradingPanel.Controls.Add(this.tradeeGrainQty);
            this.tradingPanel.Controls.Add(this.label12);
            this.tradingPanel.Controls.Add(this.label13);
            this.tradingPanel.Controls.Add(this.label14);
            this.tradingPanel.Controls.Add(this.label15);
            this.tradingPanel.Controls.Add(this.label16);
            this.tradingPanel.Controls.Add(this.traderBrickOffer);
            this.tradingPanel.Controls.Add(this.traderWoolOffer);
            this.tradingPanel.Controls.Add(this.traderOreOffer);
            this.tradingPanel.Controls.Add(this.traderGrainOffer);
            this.tradingPanel.Controls.Add(this.traderLumbOffer);
            this.tradingPanel.Controls.Add(this.traderLumQty);
            this.tradingPanel.Controls.Add(this.traderBrickQty);
            this.tradingPanel.Controls.Add(this.traderWoolQty);
            this.tradingPanel.Controls.Add(this.traderOreQty);
            this.tradingPanel.Controls.Add(this.traderGrainQty);
            this.tradingPanel.Controls.Add(this.label6);
            this.tradingPanel.Controls.Add(this.label4);
            this.tradingPanel.Controls.Add(this.label5);
            this.tradingPanel.Controls.Add(this.label3);
            this.tradingPanel.Controls.Add(this.lumberTLabel);
            this.tradingPanel.Controls.Add(this.tradingPlayerLbl);
            this.tradingPanel.Controls.Add(this.currentPlayerlbl);
            this.tradingPanel.Controls.Add(this.acceptButton);
            this.tradingPanel.Controls.Add(this.button1);
            this.tradingPanel.Location = new System.Drawing.Point(15, 17);
            this.tradingPanel.Name = "tradingPanel";
            this.tradingPanel.Size = new System.Drawing.Size(409, 305);
            this.tradingPanel.TabIndex = 40;
            this.tradingPanel.Visible = false;
            // 
            // tradeeBrkVlu
            // 
            this.tradeeBrkVlu.Location = new System.Drawing.Point(358, 68);
            this.tradeeBrkVlu.Margin = new System.Windows.Forms.Padding(2);
            this.tradeeBrkVlu.Name = "tradeeBrkVlu";
            this.tradeeBrkVlu.Size = new System.Drawing.Size(25, 20);
            this.tradeeBrkVlu.TabIndex = 67;
            // 
            // tradeeWlVlu
            // 
            this.tradeeWlVlu.Location = new System.Drawing.Point(358, 102);
            this.tradeeWlVlu.Margin = new System.Windows.Forms.Padding(2);
            this.tradeeWlVlu.Name = "tradeeWlVlu";
            this.tradeeWlVlu.Size = new System.Drawing.Size(25, 20);
            this.tradeeWlVlu.TabIndex = 66;
            // 
            // tradeeOreVlu
            // 
            this.tradeeOreVlu.Location = new System.Drawing.Point(358, 134);
            this.tradeeOreVlu.Margin = new System.Windows.Forms.Padding(2);
            this.tradeeOreVlu.Name = "tradeeOreVlu";
            this.tradeeOreVlu.Size = new System.Drawing.Size(25, 20);
            this.tradeeOreVlu.TabIndex = 65;
            // 
            // tradeeGrnVlu
            // 
            this.tradeeGrnVlu.Location = new System.Drawing.Point(358, 170);
            this.tradeeGrnVlu.Margin = new System.Windows.Forms.Padding(2);
            this.tradeeGrnVlu.Name = "tradeeGrnVlu";
            this.tradeeGrnVlu.Size = new System.Drawing.Size(25, 20);
            this.tradeeGrnVlu.TabIndex = 64;
            // 
            // tradeeLumberVlu
            // 
            this.tradeeLumberVlu.Location = new System.Drawing.Point(358, 33);
            this.tradeeLumberVlu.Margin = new System.Windows.Forms.Padding(2);
            this.tradeeLumberVlu.Name = "tradeeLumberVlu";
            this.tradeeLumberVlu.Size = new System.Drawing.Size(25, 20);
            this.tradeeLumberVlu.TabIndex = 63;
            // 
            // tradeeLumberQty
            // 
            this.tradeeLumberQty.BackColor = System.Drawing.Color.FloralWhite;
            this.tradeeLumberQty.Location = new System.Drawing.Point(248, 37);
            this.tradeeLumberQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeeLumberQty.Name = "tradeeLumberQty";
            this.tradeeLumberQty.Size = new System.Drawing.Size(19, 13);
            this.tradeeLumberQty.TabIndex = 62;
            // 
            // tradeeBrickQty
            // 
            this.tradeeBrickQty.BackColor = System.Drawing.Color.FloralWhite;
            this.tradeeBrickQty.Location = new System.Drawing.Point(248, 70);
            this.tradeeBrickQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeeBrickQty.Name = "tradeeBrickQty";
            this.tradeeBrickQty.Size = new System.Drawing.Size(19, 13);
            this.tradeeBrickQty.TabIndex = 61;
            // 
            // tradeeWoolQty
            // 
            this.tradeeWoolQty.BackColor = System.Drawing.Color.FloralWhite;
            this.tradeeWoolQty.Location = new System.Drawing.Point(248, 104);
            this.tradeeWoolQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeeWoolQty.Name = "tradeeWoolQty";
            this.tradeeWoolQty.Size = new System.Drawing.Size(19, 13);
            this.tradeeWoolQty.TabIndex = 60;
            // 
            // tradeeOreQty
            // 
            this.tradeeOreQty.BackColor = System.Drawing.Color.FloralWhite;
            this.tradeeOreQty.Location = new System.Drawing.Point(248, 138);
            this.tradeeOreQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeeOreQty.Name = "tradeeOreQty";
            this.tradeeOreQty.Size = new System.Drawing.Size(19, 13);
            this.tradeeOreQty.TabIndex = 59;
            // 
            // tradeeGrainQty
            // 
            this.tradeeGrainQty.BackColor = System.Drawing.Color.FloralWhite;
            this.tradeeGrainQty.Location = new System.Drawing.Point(248, 172);
            this.tradeeGrainQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradeeGrainQty.Name = "tradeeGrainQty";
            this.tradeeGrainQty.Size = new System.Drawing.Size(19, 13);
            this.tradeeGrainQty.TabIndex = 58;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FloralWhite;
            this.label12.Location = new System.Drawing.Point(294, 172);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "Grain";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FloralWhite;
            this.label13.Location = new System.Drawing.Point(299, 138);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Ore";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.Location = new System.Drawing.Point(296, 104);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Wool";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FloralWhite;
            this.label15.Location = new System.Drawing.Point(293, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Bricks";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.LightCyan;
            this.label16.Location = new System.Drawing.Point(290, 37);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Lumber";
            // 
            // traderBrickOffer
            // 
            this.traderBrickOffer.Location = new System.Drawing.Point(54, 70);
            this.traderBrickOffer.Margin = new System.Windows.Forms.Padding(2);
            this.traderBrickOffer.Name = "traderBrickOffer";
            this.traderBrickOffer.Size = new System.Drawing.Size(25, 20);
            this.traderBrickOffer.TabIndex = 52;
            // 
            // traderWoolOffer
            // 
            this.traderWoolOffer.Location = new System.Drawing.Point(54, 104);
            this.traderWoolOffer.Margin = new System.Windows.Forms.Padding(2);
            this.traderWoolOffer.Name = "traderWoolOffer";
            this.traderWoolOffer.Size = new System.Drawing.Size(25, 20);
            this.traderWoolOffer.TabIndex = 51;
            // 
            // traderOreOffer
            // 
            this.traderOreOffer.Location = new System.Drawing.Point(54, 136);
            this.traderOreOffer.Margin = new System.Windows.Forms.Padding(2);
            this.traderOreOffer.Name = "traderOreOffer";
            this.traderOreOffer.Size = new System.Drawing.Size(25, 20);
            this.traderOreOffer.TabIndex = 50;
            // 
            // traderGrainOffer
            // 
            this.traderGrainOffer.Location = new System.Drawing.Point(54, 172);
            this.traderGrainOffer.Margin = new System.Windows.Forms.Padding(2);
            this.traderGrainOffer.Name = "traderGrainOffer";
            this.traderGrainOffer.Size = new System.Drawing.Size(25, 20);
            this.traderGrainOffer.TabIndex = 49;
            // 
            // traderLumbOffer
            // 
            this.traderLumbOffer.Location = new System.Drawing.Point(54, 35);
            this.traderLumbOffer.Margin = new System.Windows.Forms.Padding(2);
            this.traderLumbOffer.Name = "traderLumbOffer";
            this.traderLumbOffer.Size = new System.Drawing.Size(25, 20);
            this.traderLumbOffer.TabIndex = 48;
            // 
            // traderLumQty
            // 
            this.traderLumQty.BackColor = System.Drawing.Color.FloralWhite;
            this.traderLumQty.Location = new System.Drawing.Point(173, 37);
            this.traderLumQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.traderLumQty.Name = "traderLumQty";
            this.traderLumQty.Size = new System.Drawing.Size(19, 13);
            this.traderLumQty.TabIndex = 47;
            // 
            // traderBrickQty
            // 
            this.traderBrickQty.BackColor = System.Drawing.Color.FloralWhite;
            this.traderBrickQty.Location = new System.Drawing.Point(173, 70);
            this.traderBrickQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.traderBrickQty.Name = "traderBrickQty";
            this.traderBrickQty.Size = new System.Drawing.Size(19, 13);
            this.traderBrickQty.TabIndex = 46;
            // 
            // traderWoolQty
            // 
            this.traderWoolQty.BackColor = System.Drawing.Color.FloralWhite;
            this.traderWoolQty.Location = new System.Drawing.Point(173, 104);
            this.traderWoolQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.traderWoolQty.Name = "traderWoolQty";
            this.traderWoolQty.Size = new System.Drawing.Size(19, 13);
            this.traderWoolQty.TabIndex = 45;
            // 
            // traderOreQty
            // 
            this.traderOreQty.BackColor = System.Drawing.Color.FloralWhite;
            this.traderOreQty.Location = new System.Drawing.Point(173, 138);
            this.traderOreQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.traderOreQty.Name = "traderOreQty";
            this.traderOreQty.Size = new System.Drawing.Size(19, 13);
            this.traderOreQty.TabIndex = 44;
            // 
            // traderGrainQty
            // 
            this.traderGrainQty.BackColor = System.Drawing.Color.FloralWhite;
            this.traderGrainQty.Location = new System.Drawing.Point(173, 172);
            this.traderGrainQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.traderGrainQty.Name = "traderGrainQty";
            this.traderGrainQty.Size = new System.Drawing.Size(19, 13);
            this.traderGrainQty.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FloralWhite;
            this.label6.Location = new System.Drawing.Point(109, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Grain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(114, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Ore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Location = new System.Drawing.Point(110, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Wool";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Location = new System.Drawing.Point(108, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Bricks";
            // 
            // lumberTLabel
            // 
            this.lumberTLabel.AutoSize = true;
            this.lumberTLabel.BackColor = System.Drawing.Color.LightCyan;
            this.lumberTLabel.Location = new System.Drawing.Point(104, 37);
            this.lumberTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lumberTLabel.Name = "lumberTLabel";
            this.lumberTLabel.Size = new System.Drawing.Size(42, 13);
            this.lumberTLabel.TabIndex = 38;
            this.lumberTLabel.Text = "Lumber";
            // 
            // tradingPlayerLbl
            // 
            this.tradingPlayerLbl.AutoSize = true;
            this.tradingPlayerLbl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tradingPlayerLbl.Location = new System.Drawing.Point(289, -17);
            this.tradingPlayerLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tradingPlayerLbl.Name = "tradingPlayerLbl";
            this.tradingPlayerLbl.Size = new System.Drawing.Size(45, 13);
            this.tradingPlayerLbl.TabIndex = 37;
            this.tradingPlayerLbl.Text = "Player 2";
            // 
            // currentPlayerlbl
            // 
            this.currentPlayerlbl.AutoSize = true;
            this.currentPlayerlbl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.currentPlayerlbl.Location = new System.Drawing.Point(104, -17);
            this.currentPlayerlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentPlayerlbl.Name = "currentPlayerlbl";
            this.currentPlayerlbl.Size = new System.Drawing.Size(45, 13);
            this.currentPlayerlbl.TabIndex = 36;
            this.currentPlayerlbl.Text = "Player 1";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(286, 277);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(2);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(50, 23);
            this.acceptButton.TabIndex = 35;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Trade";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Test Player Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1751, 1061);
            this.Controls.Add(this.button3);
            this.Controls.Add(tradePanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            tradePanel.ResumeLayout(false);
            tradePanel.PerformLayout();
            this.playerData.ResumeLayout(false);
            this.playerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dieP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dieP1)).EndInit();
            this.tradingPanel.ResumeLayout(false);
            this.tradingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrDieRoll;
        private Button diceRollBtn;
        public PictureBox dieP2;
        public PictureBox dieP1;
        private Button endTurnBtn;
        private Button playerDataPnlBtn;
        private Panel playerData;
        private Label grainLbl;
        private Label oreLbl;
        private Label woolLbl;
        private Label brickLbl;
        private Label lmbrLbl;
        private Label cityLbl;
        private Label settleLabel;
        private Label label1;
        private Label label2;
        private Button player2Select;
        private Button player3Select;
        private Button player4Select;
        private Button player1Select;
        private Panel tradingPanel;
        private TextBox tradeeBrkVlu;
        private TextBox tradeeWlVlu;
        private TextBox tradeeOreVlu;
        private TextBox tradeeGrnVlu;
        private TextBox tradeeLumberVlu;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox traderBrickOffer;
        private TextBox traderWoolOffer;
        private TextBox traderOreOffer;
        private TextBox traderGrainOffer;
        private TextBox traderLumbOffer;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label lumberTLabel;
        private Label tradingPlayerLbl;
        private Label currentPlayerlbl;
        private Button acceptButton;
        private Button button1;
        public Label label19;
        public Label lmbCntLbl;
        public Label brkCntLbl;
        public Label woolCntLbl;
        public Label oreCntLbl;
        public Label grnCntLbl;
        public Label label20;
        public Label label18;
        public Label tradeeLumberQty;
        public Label tradeeBrickQty;
        public Label tradeeWoolQty;
        public Label tradeeOreQty;
        public Label tradeeGrainQty;
        public Label traderLumQty;
        public Label traderBrickQty;
        public Label traderWoolQty;
        public Label traderOreQty;
        public Label traderGrainQty;
        private Button button3;
    }
}


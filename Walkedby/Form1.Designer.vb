﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RR = New System.Windows.Forms.RichTextBox()
        Me.CB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RR
        '
        Me.RR.Location = New System.Drawing.Point(79, 37)
        Me.RR.Name = "RR"
        Me.RR.Size = New System.Drawing.Size(357, 424)
        Me.RR.TabIndex = 0
        Me.RR.Text = ""
        '
        'CB
        '
        Me.CB.FormattingEnabled = True
        Me.CB.Items.AddRange(New Object() {"git rm "".vs/Walkedby/v15/.suo"" --cached", "git rm "".vs/Walkedby/v15/Solution.VC.db"" --cached", "git rm "".vs/Walkedby/v15/Solution.VC.db-shm"" --cached", "git rm "".vs/Walkedby/v15/Solution.VC.db-wal"" --cached", "dfadfad", "", "dagdagd", "", "44545"})
        Me.CB.Location = New System.Drawing.Point(635, 187)
        Me.CB.Name = "CB"
        Me.CB.Size = New System.Drawing.Size(138, 29)
        Me.CB.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(858, 533)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CB)
        Me.Controls.Add(Me.RR)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RR As RichTextBox
    Friend WithEvents CB As ComboBox
    Friend WithEvents Button1 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SFDialogEnregistrer = New System.Windows.Forms.SaveFileDialog()
        Me.OFDialogExplorer = New System.Windows.Forms.OpenFileDialog()
        Me.Cmbaction = New System.Windows.Forms.ComboBox()
        Me.cmbshift = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnExport.Font = New System.Drawing.Font("Yu Gothic UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(576, 363)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(197, 60)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Exporter"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'OFDialogExplorer
        '
        Me.OFDialogExplorer.FileName = "OpenFileDialog1"
        '
        'Cmbaction
        '
        Me.Cmbaction.DropDownHeight = 300
        Me.Cmbaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmbaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbaction.FormattingEnabled = True
        Me.Cmbaction.IntegralHeight = False
        Me.Cmbaction.Location = New System.Drawing.Point(220, 85)
        Me.Cmbaction.Name = "Cmbaction"
        Me.Cmbaction.Size = New System.Drawing.Size(465, 41)
        Me.Cmbaction.TabIndex = 3
        '
        'cmbshift
        '
        Me.cmbshift.DisplayMember = "6-14"
        Me.cmbshift.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbshift.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbshift.FormattingEnabled = True
        Me.cmbshift.Items.AddRange(New Object() {"06-14", "14-22", "22-06"})
        Me.cmbshift.Location = New System.Drawing.Point(220, 220)
        Me.cmbshift.Name = "cmbshift"
        Me.cmbshift.Size = New System.Drawing.Size(465, 41)
        Me.cmbshift.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 158)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(465, 40)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria Math", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 117)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Place of action"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria Math", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 117)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Data Scan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cambria Math", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 117)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Shift"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 467)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbshift)
        Me.Controls.Add(Me.Cmbaction)
        Me.Controls.Add(Me.btnExport)
        Me.Name = "Form1"
        Me.Text = "Transfert_Excel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents SFDialogEnregistrer As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFDialogExplorer As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Cmbaction As System.Windows.Forms.ComboBox
    Friend WithEvents cmbshift As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class

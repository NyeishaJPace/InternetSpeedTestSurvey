<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        Me.lstSpeeds = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverageInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(358, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.BackColor = System.Drawing.Color.Olive
        Me.btnEnterSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSpeed.Location = New System.Drawing.Point(387, 92)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(244, 58)
        Me.btnEnterSpeed.TabIndex = 1
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = False
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.BackColor = System.Drawing.Color.White
        Me.lblAverageSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSpeed.Location = New System.Drawing.Point(445, 393)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(186, 18)
        Me.lblAverageSpeed.TabIndex = 2
        Me.lblAverageSpeed.Text = "Average Internet Speed:"
        '
        'lstSpeeds
        '
        Me.lstSpeeds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeeds.FormattingEnabled = True
        Me.lstSpeeds.ItemHeight = 20
        Me.lstSpeeds.Location = New System.Drawing.Point(678, 163)
        Me.lstSpeeds.Name = "lstSpeeds"
        Me.lstSpeeds.ScrollAlwaysVisible = True
        Me.lstSpeeds.Size = New System.Drawing.Size(86, 164)
        Me.lstSpeeds.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(515, 341)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAverageInput
        '
        Me.lblAverageInput.AutoSize = True
        Me.lblAverageInput.BackColor = System.Drawing.Color.White
        Me.lblAverageInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInput.Location = New System.Drawing.Point(637, 393)
        Me.lblAverageInput.Name = "lblAverageInput"
        Me.lblAverageInput.Size = New System.Drawing.Size(57, 18)
        Me.lblAverageInput.TabIndex = 5
        Me.lblAverageInput.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAverageInput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstSpeeds)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents lblAverageSpeed As Label
    Friend WithEvents lstSpeeds As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAverageInput As Label
End Class

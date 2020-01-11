<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StandardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MultiplicationTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnpm = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnplus = New System.Windows.Forms.Button()
        Me.btnminus = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnequals = New System.Windows.Forms.Button()
        Me.btndot = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnpercent = New System.Windows.Forms.Button()
        Me.btnoct = New System.Windows.Forms.Button()
        Me.btnmod = New System.Windows.Forms.Button()
        Me.btnexp = New System.Windows.Forms.Button()
        Me.btnfraction = New System.Windows.Forms.Button()
        Me.btnbin = New System.Windows.Forms.Button()
        Me.btncos = New System.Windows.Forms.Button()
        Me.btncosh = New System.Windows.Forms.Button()
        Me.btncube = New System.Windows.Forms.Button()
        Me.btnln = New System.Windows.Forms.Button()
        Me.btndec = New System.Windows.Forms.Button()
        Me.btnsin = New System.Windows.Forms.Button()
        Me.btnhex = New System.Windows.Forms.Button()
        Me.btnsinh = New System.Windows.Forms.Button()
        Me.btntan = New System.Windows.Forms.Button()
        Me.btntanh = New System.Windows.Forms.Button()
        Me.btnsquared = New System.Windows.Forms.Button()
        Me.btnsqrt = New System.Windows.Forms.Button()
        Me.btnlog = New System.Windows.Forms.Button()
        Me.btnpi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnconvert = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.grouptemp = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.grouptemp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 29)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(459, 59)
        Me.txtDisplay.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "⌫"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(831, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StandardToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.TemperatureToolStripMenuItem, Me.UnitConversionToolStripMenuItem, Me.MultiplicationTableToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'StandardToolStripMenuItem
        '
        Me.StandardToolStripMenuItem.Name = "StandardToolStripMenuItem"
        Me.StandardToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.StandardToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'TemperatureToolStripMenuItem
        '
        Me.TemperatureToolStripMenuItem.Name = "TemperatureToolStripMenuItem"
        Me.TemperatureToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.TemperatureToolStripMenuItem.Text = "Temperature"
        '
        'UnitConversionToolStripMenuItem
        '
        Me.UnitConversionToolStripMenuItem.Name = "UnitConversionToolStripMenuItem"
        Me.UnitConversionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.UnitConversionToolStripMenuItem.Text = "Unit Conversion"
        '
        'MultiplicationTableToolStripMenuItem
        '
        Me.MultiplicationTableToolStripMenuItem.Name = "MultiplicationTableToolStripMenuItem"
        Me.MultiplicationTableToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.MultiplicationTableToolStripMenuItem.Text = "Multiplication Table"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ViewsToolStripMenuItem
        '
        Me.ViewsToolStripMenuItem.Name = "ViewsToolStripMenuItem"
        Me.ViewsToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ViewsToolStripMenuItem.Text = "Views"
        '
        'btnCE
        '
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(68, 94)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(50, 50)
        Me.btnCE.TabIndex = 3
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = True
        '
        'btnC
        '
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(124, 94)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(50, 50)
        Me.btnC.TabIndex = 4
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = True
        '
        'btnpm
        '
        Me.btnpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpm.Location = New System.Drawing.Point(180, 94)
        Me.btnpm.Name = "btnpm"
        Me.btnpm.Size = New System.Drawing.Size(50, 50)
        Me.btnpm.TabIndex = 5
        Me.btnpm.Text = "±"
        Me.btnpm.UseVisualStyleBackColor = True
        '
        'btnmultiply
        '
        Me.btnmultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmultiply.Location = New System.Drawing.Point(180, 262)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(50, 50)
        Me.btnmultiply.TabIndex = 9
        Me.btnmultiply.Text = "*"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(124, 262)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(50, 50)
        Me.btn3.TabIndex = 8
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(68, 262)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(50, 50)
        Me.btn2.TabIndex = 7
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 262)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(50, 50)
        Me.btn1.TabIndex = 6
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(12, 150)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(50, 50)
        Me.btn7.TabIndex = 6
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(68, 150)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(50, 50)
        Me.btn8.TabIndex = 7
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(124, 150)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(50, 50)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnplus
        '
        Me.btnplus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnplus.Location = New System.Drawing.Point(180, 150)
        Me.btnplus.Name = "btnplus"
        Me.btnplus.Size = New System.Drawing.Size(50, 50)
        Me.btnplus.TabIndex = 9
        Me.btnplus.Text = "+"
        Me.btnplus.UseVisualStyleBackColor = True
        '
        'btnminus
        '
        Me.btnminus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnminus.Location = New System.Drawing.Point(180, 206)
        Me.btnminus.Name = "btnminus"
        Me.btnminus.Size = New System.Drawing.Size(50, 50)
        Me.btnminus.TabIndex = 13
        Me.btnminus.Text = "-"
        Me.btnminus.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(124, 206)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(50, 50)
        Me.btn6.TabIndex = 12
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(68, 206)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(50, 50)
        Me.btn5.TabIndex = 11
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 206)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(50, 50)
        Me.btn4.TabIndex = 10
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btndivide
        '
        Me.btndivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndivide.Location = New System.Drawing.Point(180, 318)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(50, 50)
        Me.btndivide.TabIndex = 17
        Me.btndivide.Text = "/"
        Me.btndivide.UseVisualStyleBackColor = True
        '
        'btnequals
        '
        Me.btnequals.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnequals.Location = New System.Drawing.Point(124, 318)
        Me.btnequals.Name = "btnequals"
        Me.btnequals.Size = New System.Drawing.Size(50, 50)
        Me.btnequals.TabIndex = 16
        Me.btnequals.Text = "="
        Me.btnequals.UseVisualStyleBackColor = True
        '
        'btndot
        '
        Me.btndot.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndot.Location = New System.Drawing.Point(68, 318)
        Me.btndot.Name = "btndot"
        Me.btndot.Size = New System.Drawing.Size(50, 50)
        Me.btndot.TabIndex = 15
        Me.btndot.Text = "."
        Me.btndot.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(12, 318)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(50, 50)
        Me.btn0.TabIndex = 14
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnpercent
        '
        Me.btnpercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpercent.Location = New System.Drawing.Point(421, 318)
        Me.btnpercent.Name = "btnpercent"
        Me.btnpercent.Size = New System.Drawing.Size(50, 50)
        Me.btnpercent.TabIndex = 37
        Me.btnpercent.Text = "%"
        Me.btnpercent.UseVisualStyleBackColor = True
        '
        'btnoct
        '
        Me.btnoct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnoct.Location = New System.Drawing.Point(365, 318)
        Me.btnoct.Name = "btnoct"
        Me.btnoct.Size = New System.Drawing.Size(50, 50)
        Me.btnoct.TabIndex = 36
        Me.btnoct.Text = "Oct"
        Me.btnoct.UseVisualStyleBackColor = True
        '
        'btnmod
        '
        Me.btnmod.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmod.Location = New System.Drawing.Point(309, 318)
        Me.btnmod.Name = "btnmod"
        Me.btnmod.Size = New System.Drawing.Size(50, 50)
        Me.btnmod.TabIndex = 35
        Me.btnmod.Text = "Mod"
        Me.btnmod.UseVisualStyleBackColor = True
        '
        'btnexp
        '
        Me.btnexp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexp.Location = New System.Drawing.Point(253, 318)
        Me.btnexp.Name = "btnexp"
        Me.btnexp.Size = New System.Drawing.Size(50, 50)
        Me.btnexp.TabIndex = 34
        Me.btnexp.Text = "Exp"
        Me.btnexp.UseVisualStyleBackColor = True
        '
        'btnfraction
        '
        Me.btnfraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfraction.Location = New System.Drawing.Point(421, 206)
        Me.btnfraction.Name = "btnfraction"
        Me.btnfraction.Size = New System.Drawing.Size(50, 50)
        Me.btnfraction.TabIndex = 33
        Me.btnfraction.Text = "1/x"
        Me.btnfraction.UseVisualStyleBackColor = True
        '
        'btnbin
        '
        Me.btnbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbin.Location = New System.Drawing.Point(365, 206)
        Me.btnbin.Name = "btnbin"
        Me.btnbin.Size = New System.Drawing.Size(50, 50)
        Me.btnbin.TabIndex = 32
        Me.btnbin.Text = "Bin"
        Me.btnbin.UseVisualStyleBackColor = True
        '
        'btncos
        '
        Me.btncos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncos.Location = New System.Drawing.Point(309, 206)
        Me.btncos.Name = "btncos"
        Me.btncos.Size = New System.Drawing.Size(50, 50)
        Me.btncos.TabIndex = 31
        Me.btncos.Text = "Cos"
        Me.btncos.UseVisualStyleBackColor = True
        '
        'btncosh
        '
        Me.btncosh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncosh.Location = New System.Drawing.Point(253, 206)
        Me.btncosh.Name = "btncosh"
        Me.btncosh.Size = New System.Drawing.Size(50, 50)
        Me.btncosh.TabIndex = 30
        Me.btncosh.Text = "Cosh"
        Me.btncosh.UseVisualStyleBackColor = True
        '
        'btncube
        '
        Me.btncube.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncube.Location = New System.Drawing.Point(421, 150)
        Me.btncube.Name = "btncube"
        Me.btncube.Size = New System.Drawing.Size(50, 50)
        Me.btncube.TabIndex = 29
        Me.btncube.Text = "x^3"
        Me.btncube.UseVisualStyleBackColor = True
        '
        'btnln
        '
        Me.btnln.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnln.Location = New System.Drawing.Point(421, 262)
        Me.btnln.Name = "btnln"
        Me.btnln.Size = New System.Drawing.Size(50, 50)
        Me.btnln.TabIndex = 28
        Me.btnln.Text = "ln x"
        Me.btnln.UseVisualStyleBackColor = True
        '
        'btndec
        '
        Me.btndec.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndec.Location = New System.Drawing.Point(365, 150)
        Me.btndec.Name = "btndec"
        Me.btndec.Size = New System.Drawing.Size(50, 50)
        Me.btndec.TabIndex = 27
        Me.btndec.Text = "Dec"
        Me.btndec.UseVisualStyleBackColor = True
        '
        'btnsin
        '
        Me.btnsin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsin.Location = New System.Drawing.Point(309, 150)
        Me.btnsin.Name = "btnsin"
        Me.btnsin.Size = New System.Drawing.Size(50, 50)
        Me.btnsin.TabIndex = 25
        Me.btnsin.Text = "Sin"
        Me.btnsin.UseVisualStyleBackColor = True
        '
        'btnhex
        '
        Me.btnhex.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhex.Location = New System.Drawing.Point(365, 262)
        Me.btnhex.Name = "btnhex"
        Me.btnhex.Size = New System.Drawing.Size(50, 50)
        Me.btnhex.TabIndex = 26
        Me.btnhex.Text = "Hex"
        Me.btnhex.UseVisualStyleBackColor = True
        '
        'btnsinh
        '
        Me.btnsinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsinh.Location = New System.Drawing.Point(253, 150)
        Me.btnsinh.Name = "btnsinh"
        Me.btnsinh.Size = New System.Drawing.Size(50, 50)
        Me.btnsinh.TabIndex = 23
        Me.btnsinh.Text = "Sinh"
        Me.btnsinh.UseVisualStyleBackColor = True
        '
        'btntan
        '
        Me.btntan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntan.Location = New System.Drawing.Point(309, 262)
        Me.btntan.Name = "btntan"
        Me.btntan.Size = New System.Drawing.Size(50, 50)
        Me.btntan.TabIndex = 24
        Me.btntan.Text = "Tan"
        Me.btntan.UseVisualStyleBackColor = True
        '
        'btntanh
        '
        Me.btntanh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntanh.Location = New System.Drawing.Point(253, 262)
        Me.btntanh.Name = "btntanh"
        Me.btntanh.Size = New System.Drawing.Size(50, 50)
        Me.btntanh.TabIndex = 22
        Me.btntanh.Text = "Tanh"
        Me.btntanh.UseVisualStyleBackColor = True
        '
        'btnsquared
        '
        Me.btnsquared.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsquared.Location = New System.Drawing.Point(421, 94)
        Me.btnsquared.Name = "btnsquared"
        Me.btnsquared.Size = New System.Drawing.Size(50, 50)
        Me.btnsquared.TabIndex = 21
        Me.btnsquared.Text = "x^2"
        Me.btnsquared.UseVisualStyleBackColor = True
        '
        'btnsqrt
        '
        Me.btnsqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsqrt.Location = New System.Drawing.Point(365, 94)
        Me.btnsqrt.Name = "btnsqrt"
        Me.btnsqrt.Size = New System.Drawing.Size(50, 50)
        Me.btnsqrt.TabIndex = 20
        Me.btnsqrt.Text = "Sqrt"
        Me.btnsqrt.UseVisualStyleBackColor = True
        '
        'btnlog
        '
        Me.btnlog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlog.Location = New System.Drawing.Point(309, 94)
        Me.btnlog.Name = "btnlog"
        Me.btnlog.Size = New System.Drawing.Size(50, 50)
        Me.btnlog.TabIndex = 19
        Me.btnlog.Text = "Log"
        Me.btnlog.UseVisualStyleBackColor = True
        '
        'btnpi
        '
        Me.btnpi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpi.Location = New System.Drawing.Point(253, 94)
        Me.btnpi.Name = "btnpi"
        Me.btnpi.Size = New System.Drawing.Size(50, 50)
        Me.btnpi.TabIndex = 18
        Me.btnpi.Text = "π"
        Me.btnpi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Temperature"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = " Enter the value to convert:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(198, 48)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 17)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Select Temperature Conversion:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(61, 124)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(190, 21)
        Me.RadioButton1.TabIndex = 42
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Celsius to Fahrentheit "
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(61, 157)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(185, 21)
        Me.RadioButton2.TabIndex = 43
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Fahrentheit to Celsius"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(61, 193)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(70, 21)
        Me.RadioButton3.TabIndex = 44
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Kelvin"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(198, 252)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Converted Value:"
        '
        'btnconvert
        '
        Me.btnconvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvert.Location = New System.Drawing.Point(61, 302)
        Me.btnconvert.Name = "btnconvert"
        Me.btnconvert.Size = New System.Drawing.Size(75, 23)
        Me.btnconvert.TabIndex = 47
        Me.btnconvert.Text = "Convert"
        Me.btnconvert.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(198, 302)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 48
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'grouptemp
        '
        Me.grouptemp.Controls.Add(Me.btnreset)
        Me.grouptemp.Controls.Add(Me.btnconvert)
        Me.grouptemp.Controls.Add(Me.Label4)
        Me.grouptemp.Controls.Add(Me.TextBox2)
        Me.grouptemp.Controls.Add(Me.RadioButton3)
        Me.grouptemp.Controls.Add(Me.RadioButton2)
        Me.grouptemp.Controls.Add(Me.RadioButton1)
        Me.grouptemp.Controls.Add(Me.Label3)
        Me.grouptemp.Controls.Add(Me.TextBox1)
        Me.grouptemp.Controls.Add(Me.Label2)
        Me.grouptemp.Controls.Add(Me.Label1)
        Me.grouptemp.Location = New System.Drawing.Point(482, 26)
        Me.grouptemp.Name = "grouptemp"
        Me.grouptemp.Size = New System.Drawing.Size(348, 352)
        Me.grouptemp.TabIndex = 49
        Me.grouptemp.TabStop = False
        Me.grouptemp.Text = "GroupBox1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 377)
        Me.Controls.Add(Me.grouptemp)
        Me.Controls.Add(Me.btnpercent)
        Me.Controls.Add(Me.btnoct)
        Me.Controls.Add(Me.btnmod)
        Me.Controls.Add(Me.btnexp)
        Me.Controls.Add(Me.btnfraction)
        Me.Controls.Add(Me.btnbin)
        Me.Controls.Add(Me.btncos)
        Me.Controls.Add(Me.btncosh)
        Me.Controls.Add(Me.btncube)
        Me.Controls.Add(Me.btnln)
        Me.Controls.Add(Me.btndec)
        Me.Controls.Add(Me.btnsin)
        Me.Controls.Add(Me.btnhex)
        Me.Controls.Add(Me.btnsinh)
        Me.Controls.Add(Me.btntan)
        Me.Controls.Add(Me.btntanh)
        Me.Controls.Add(Me.btnsquared)
        Me.Controls.Add(Me.btnsqrt)
        Me.Controls.Add(Me.btnlog)
        Me.Controls.Add(Me.btnpi)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnequals)
        Me.Controls.Add(Me.btndot)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnminus)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnplus)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnpm)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grouptemp.ResumeLayout(False)
        Me.grouptemp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StandardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemperatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitConversionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MultiplicationTableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCE As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnpm As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnequals As Button
    Friend WithEvents btndot As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnpercent As Button
    Friend WithEvents btnoct As Button
    Friend WithEvents btnmod As Button
    Friend WithEvents btnexp As Button
    Friend WithEvents btnbin As Button
    Friend WithEvents btncos As Button
    Friend WithEvents btncosh As Button
    Friend WithEvents btncube As Button
    Friend WithEvents btnln As Button
    Friend WithEvents btndec As Button
    Friend WithEvents btnsin As Button
    Friend WithEvents btnhex As Button
    Friend WithEvents btnsinh As Button
    Friend WithEvents btntan As Button
    Friend WithEvents btntanh As Button
    Friend WithEvents btnsquared As Button
    Friend WithEvents btnsqrt As Button
    Friend WithEvents btnlog As Button
    Friend WithEvents btnpi As Button
    Friend WithEvents btnfraction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnconvert As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents grouptemp As GroupBox
End Class

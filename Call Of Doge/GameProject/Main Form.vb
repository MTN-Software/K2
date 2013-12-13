' Program:      Call of Doge
' Desc:         Deplete enemy health
' Programmer:   Thomas Maloney on December 6, 2013

Imports System.Media.SoundPlayer
Imports GameProject.AppVars

Public Class frmMain
    Private playerPlayer As Player
    Private playerEnemy As Player
    Private blnPlayerLost As Boolean
    Private blnplayer As Boolean
    Private blnShotLeft As Boolean
    Dim intPlayerHealth As Integer
    Dim intEHealth As Integer
    Private intDifficulty As Integer = 10
    Private intDamagePerHit As Integer = 5


    Private Sub tlbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbExit.Click
        Me.Close()
    End Sub

    Private Sub tlbAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlbAbout.Click
        frmAbout.Visible = True
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' handle key presses
        Select Case e.KeyCode
            ' pause the game and sets variables to save
            Case Keys.Escape
                showMenu()
                ' sets values to structure Player 
                playerPlayer.intY = picShibe.Location.Y
                playerPlayer.intX = picShibe.Location.X
                If (picShibe.ImageLocation = ("\\s-students\student-homes\Mal502563\Visual Studio 2008\Projects\GameSolution\GameProject\dogeShibeFlip.jpg")) Then
                    playerPlayer.blnIsLeft = True
                Else
                    playerPlayer.blnIsLeft = False
                End If
                playerEnemy.intX = picEnemySprite.Location.X
                playerEnemy.intY = picEnemySprite.Location.Y
                ' shoot left
            Case Keys.Left
                picLaser.Enabled = True
                picLaser.Location = New Point(picShibe.Location.X - 166, picShibe.Location.Y + 49)
                picLaser.Visible = True
                blnShotLeft = True
                Do Until picLaser.Bounds.IntersectsWith(picLeftBoundry.Bounds) Or picLaser.Bounds.IntersectsWith(picEnemySprite.Bounds) Or picLaser.Bounds.IntersectsWith(picShibe.Bounds)
                    picLaser.Location = New Point(picLaser.Location.X - 20, picLaser.Location.Y)
                    Me.Update()
                Loop
                picLaser.Location = New Point(picLaser.Location.X, picLaser.Location.Y)
                picLaser.Visible = False
                picLaser.Enabled = False

                ' shoot right
            Case Keys.Right
                picLaser.Enabled = True
                picLaser.Location = New Point(picShibe.Location.X + 166, picShibe.Location.Y + 49)
                picLaser.Visible = True
                blnShotLeft = False
                tmrGame.Enabled = True
                tmrShoot.Enabled = True
        End Select
    End Sub

    Private Sub frmMain_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        Select Case e.KeyChar
            ' move up
            Case "w", "W"
                picShibe.Location = New Point(picShibe.Location.X, picShibe.Location.Y - 30)
                Me.Update()
                picShibe.Location = New Point(picShibe.Location.X, picShibe.Location.Y + 30)

                ' move down
            Case "s", "S"
                picShibe.Location = New Point(picShibe.Location.X, picShibe.Location.Y + 10)
                Me.Update()

                ' move left
            Case "a", "A"
                'picShibe.Image = Image.FromFile("\\s-students\student-homes\Mal502563\Visual Studio 2008\Projects\GameSolution\GameProject\dogeShibe.jpg")
                picShibe.Location = New Point(picShibe.Location.X - 10, picShibe.Location.Y)
                Me.Update()

                ' move right
            Case "d", "D"
                'picShibe.Image = Image.FromFile("\\s-students\student-homes\Mal502563\Visual Studio 2008\Projects\GameSolution\GameProject\dogeShibeFlip.jpg")
                picShibe.Location = New Point(picShibe.Location.X + 10, picShibe.Location.Y)
                Me.Update()
        End Select

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub startGame()
        ' start the game
        lblGameTitle.Visible = False
        btnStart.Visible = False
        btnExit.Visible = False
        lblGameTitle.Enabled = False
        btnStart.Enabled = False
        btnExit.Enabled = False
        tmrGame.Enabled = True
        btnLoad.Visible = False
        btnSave.Visible = False
        btnLoad.Enabled = False
        btnSave.Enabled = False
        btnBack.Visible = False
        btnBack.Enabled = False
        btnLoadSaved.Visible = False
        btnNewSave.Visible = False
        btnLoadSaved.Enabled = False
        btnNewSave.Enabled = False
        intPlayerHealth = 100
        intEHealth = 100
        'My.Computer.Audio.Play("\\s-students\student-homes\Mal502563\Visual Studio 2008\Projects\GameSolution\GameProject\TranceLoop.wav", AudioPlayMode.BackgroundLoop)
        Me.Focus()
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        startGame()
    End Sub

    Private Sub tmrGame_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        ' set variables
        Dim randWillShoot As New Random
        Dim randRandomPosX As New Random

        Dim blnHasShot As New Boolean

        Dim intRandomPosX As Integer = randRandomPosX.Next(-10, 11)


        If (picEnemySprite.Bounds.IntersectsWith(picRightBoundry.Bounds) = False) Then
            picEnemySprite.Location = New Point(picEnemySprite.Location.X + intRandomPosX, picEnemySprite.Location.Y)

        Else
            picEnemySprite.Location = New Point(picEnemySprite.Location.X - 10, picEnemySprite.Location.Y)
        End If
        ' allows player movement while shooting
        Dim intWillShoot As Integer = randWillShoot.Next(0, 101)
        If picELasor.Visible = False Then


            If (intWillShoot < intDifficulty) Then
                'MessageBox.Show("Shoot!")
                picELasor.Enabled = True
                picELasor.Location = New Point(picEnemySprite.Location.X - 166, picEnemySprite.Location.Y + 49)
                picELasor.Visible = True
                enemyShoot()

            ElseIf (intWillShoot > intDifficulty) Then
                'MessageBox.Show("Shoot! Again")
            End If
        ElseIf picELasor.Visible = True Then
            If ((picELasor.Bounds.IntersectsWith(picLeftBoundry.Bounds) = False) And (picELasor.Bounds.IntersectsWith(picShibe.Bounds) = False)) Then

                picELasor.Location = New Point(picELasor.Location.X - 50, picELasor.Location.Y)

            ElseIf ((picELasor.Bounds.IntersectsWith(picLeftBoundry.Bounds) = True) Or (picELasor.Bounds.IntersectsWith(picShibe.Bounds) = True)) Then
                picELasor.Visible = False
                picELasor.Enabled = False
                picELasor.Location = New Point(51, 141)


            End If
        End If

        ' Debug info
        mnuX.Text = "X = " & picELasor.Location.X.ToString
        mnuY.Text = "Y = " & picELasor.Location.Y.ToString
        mnuRandomInt.Text = "intWillShoot = " & intWillShoot.ToString
        mnuMyX.Text = "My X = " & picLaser.Location.X.ToString
        mnuMyY.Text = "My Y = " & picLaser.Location.Y.ToString
        ' /Debug info

        If (picEnemySprite.Bounds.IntersectsWith(picRightBoundry.Bounds) = False) And (picEnemySprite.Location.X > 765) Then
            picEnemySprite.Location = New Point(picEnemySprite.Location.X + intRandomPosX, picEnemySprite.Location.Y)
        End If

        If ((picELasor.Bounds.IntersectsWith(picShibe.Bounds) = True) And (prgPlayerHealth.Value > 0)) Then
            intPlayerHealth = intPlayerHealth - 5
            prgPlayerHealth.Value = intPlayerHealth
            picELasor.Visible = False
            picELasor.Location = New Point(0, 0)
            picELasor.Enabled = False
        End If

        If ((picLaser.Bounds.IntersectsWith(picEnemySprite.Bounds) = True) And (prgEHealth.Value > 0)) Then
            intEHealth = intEHealth - intDamagePerHit
            prgEHealth.Value = intEHealth
            picLaser.Visible = False
            picLaser.Location = New Point(0, 0)
            picLaser.Enabled = False

        End If

        If (prgEHealth.Value = 0) Then
            blnplayer = True
            blnPlayerLost = False
            strWinnerMessage = ("You have won.")
            frmWinner.Visible = True
            tmrGame.Enabled = False
        ElseIf (prgPlayerHealth.Value = 0) Then
            blnPlayerLost = True
            blnplayer = False
            strWinnerMessage = ("You have lost.")
            frmWinner.Visible = True
            tmrGame.Enabled = False
        End If
        Me.Update()
    End Sub


    Private Sub tmrShoot_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrShoot.Tick


        If picLaser.Bounds.IntersectsWith(picRightBoundry.Bounds) = True Or picLaser.Bounds.IntersectsWith(picEnemySprite.Bounds) = True Then
            picLaser.Visible = False
            picLaser.Location = New Point(0, 0)
            picLaser.Enabled = False
            tmrShoot.Enabled = False

        ElseIf picLaser.Bounds.IntersectsWith(picRightBoundry.Bounds) = False And picLaser.Bounds.IntersectsWith(picEnemySprite.Bounds) = False Then
            picLaser.Location = New Point(picLaser.Location.X + 50, picLaser.Location.Y)

        End If
    End Sub


    Private Sub enemyShoot()
        If ((picELasor.Bounds.IntersectsWith(picLeftBoundry.Bounds) = False) And (picELasor.Bounds.IntersectsWith(picShibe.Bounds) = False)) Then

            picELasor.Location = New Point(picELasor.Location.X - 50, picELasor.Location.Y)

        ElseIf ((picELasor.Bounds.IntersectsWith(picLeftBoundry.Bounds) = True) Or (picELasor.Bounds.IntersectsWith(picShibe.Bounds) = True)) Then
            picELasor.Visible = False
            picELasor.Location = New Point(51, 141)
            picELasor.Enabled = False

        End If


    End Sub



    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DogeSaveDataSet.tblGame' table. You can move, or remove it, as needed.
        'Me.TblGameTableAdapter.Fill(Me.DogeSaveDataSet.tblGame)
        showMenu()

    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        btnNewSave.Enabled = True
        btnLoadSaved.Enabled = True
        btnBack.Enabled = True
        btnNewSave.Visible = True
        btnLoadSaved.Visible = True
        btnBack.Visible = True

        ' sliding animation
        Do Until btnExit.Bounds.IntersectsWith(picLeftBoundry.Bounds)
            btnStart.Location = New Point(btnStart.Location.X - 20, btnStart.Location.Y)
            btnSave.Location = New Point(btnSave.Location.X - 20, btnSave.Location.Y)
            btnLoad.Location = New Point(btnLoad.Location.X - 20, btnLoad.Location.Y)
            btnExit.Location = New Point(btnExit.Location.X - 20, btnLoad.Location.Y)
            btnNewSave.Location = New Point(btnNewSave.Location.X - 20, btnNewSave.Location.Y)
            btnLoadSaved.Location = New Point(btnLoadSaved.Location.X - 20, btnLoadSaved.Location.Y)
            btnBack.Location = New Point(btnBack.Location.X - 20, btnBack.Location.Y)
            Me.Update()
        Loop

        btnStart.Visible = False
        btnLoad.Visible = False
        btnSave.Visible = False
        btnExit.Visible = False
    End Sub

    Private Sub showMenu()
        lblGameTitle.Visible = True
        btnStart.Visible = True
        btnExit.Visible = True
        lblGameTitle.Enabled = True
        btnStart.Enabled = True
        btnExit.Enabled = True
        tmrGame.Enabled = False
        tmrJump.Enabled = False
        btnNewSave.Visible = False
        btnBack.Visible = False
        btnBack.Enabled = False
        btnLoadSaved.Visible = False
        btnLoadSaved.Enabled = False
        btnNewSave.Enabled = False
        btnLoad.Visible = True
        btnLoad.Enabled = True
        btnSave.Visible = True
        btnSave.Enabled = True

        Me.Focus()
    End Sub

    Private Sub btnNewSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewSave.Click
        startGame()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        btnExit.Enabled = True
        btnStart.Visible = True
        btnLoad.Visible = True
        btnSave.Visible = True
        btnExit.Visible = True
        ' reverse sliding animation
        Do Until btnBack.Bounds.IntersectsWith(picRightBoundry.Bounds)
            btnStart.Location = New Point(btnStart.Location.X + 20, btnStart.Location.Y)
            btnSave.Location = New Point(btnSave.Location.X + 20, btnSave.Location.Y)
            btnLoad.Location = New Point(btnLoad.Location.X + 20, btnLoad.Location.Y)
            btnExit.Location = New Point(btnExit.Location.X + 20, btnLoad.Location.Y)
            btnNewSave.Location = New Point(btnNewSave.Location.X + 20, btnNewSave.Location.Y)
            btnLoadSaved.Location = New Point(btnLoadSaved.Location.X + 20, btnLoadSaved.Location.Y)
            btnBack.Location = New Point(btnBack.Location.X + 20, btnBack.Location.Y)
            Me.Update()
        Loop

        btnNewSave.Visible = False
        btnLoadSaved.Visible = False
        btnBack.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.TblGameTableAdapter.Insert(playerPlayer.intY, playerPlayer.intX, intPlayerHealth, intEHealth, playerEnemy.intY, playerEnemy.intX, True)
            Me.TblGameTableAdapter.Update(Me.DogeSaveDataSet)
        Catch ex As Exception
            MessageBox.Show("I cannot do that for you" & vbNewLine & ex.Message, _
                            "Wow... much embarrass.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLoadSaved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadSaved.Click
        playerPlayer.intY = picShibe.Location.Y
        playerPlayer.intX = picShibe.Location.X
        'If (picShibe.ImageLocation = ("\\s-students\student-homes\Mal502563\Visual Studio 2008\Projects\GameSolution\GameProject\dogeShibeFlip.jpg")) Then
        'playerPlayer.blnIsLeft = True
        'Else
        'playerPlayer.blnIsLeft = False
        'End If
        playerEnemy.intX = picEnemySprite.Location.X
        playerEnemy.intY = picEnemySprite.Location.Y
    End Sub







    Private Sub mnuEasy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEasy.Click
        intDifficulty = 3
        intDamagePerHit = 20
        picEnemySprite.BackgroundImage = My.Resources.callofDoge
        picEnemySprite.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub mnuMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedium.Click
        intDifficulty = 10
        intDamagePerHit = 10
        picEnemySprite.BackgroundImage = My.Resources.callofDoge
        picEnemySprite.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub mnuDifficult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDifficult.Click
        intDifficulty = 17
        intDamagePerHit = 5
        picEnemySprite.BackgroundImage = My.Resources.callofDoge
        picEnemySprite.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub mnuDogeBirdOfShibe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDogeBirdOfShibe.Click
        intDifficulty = 50
        intDamagePerHit = 1
        picEnemySprite.BackgroundImage = Image.FromFile("D:\GameProject\dogeBirgOfShibe.jpg")
        picEnemySprite.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub mnuHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelp.Click
        Const strHelp As String = "Controls" & vbNewLine & vbNewLine & "Right:  d" & vbNewLine & "left:      a" & vbNewLine & "jump:  w" & vbNewLine & "down:  s" & vbNewLine & "shoot:  right arrow key"
        MessageBox.Show(strHelp, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

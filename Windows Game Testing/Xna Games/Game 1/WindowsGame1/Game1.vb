''' <summary>
''' This is the main type for your game
''' </summary>
Public Class Game1
    Inherits Microsoft.Xna.Framework.Game

    Private WithEvents graphics As GraphicsDeviceManager
    Private WithEvents spriteBatch As SpriteBatch
    Private WithEvents BackgroundBatch As SpriteBatch
    Private WithEvents spriteLasor As SpriteBatch
    Private WithEvents spriteGroundBatch As SpriteBatch
    Private WithEvents effects As Effect


    Dim rectStartPos As New Rectangle(0, 250, 250, 200)
    Dim mytexture As Texture2D
    Dim myBackground As Texture2D
    Dim myLasor As Texture2D
    Dim myGround As Texture2D
    Dim spriteposition As Vector2 = Vector2.Zero
    Dim spritespeed As Vector2 = New Vector2(50.0F, 50.0F)




    Public Sub New()
        graphics = New GraphicsDeviceManager(Me)
        Content.RootDirectory = "Content"
    End Sub

    ''' <summary>
    ''' Allows the game to perform any initialization it needs to before starting to run.
    ''' This is where it can query for any required services and load any non-graphic
    ''' related content.  Calling MyBase.Initialize will enumerate through any components
    ''' and initialize them as well.
    ''' </summary>
    Protected Overrides Sub Initialize()
        ' TODO: Add your initialization logic here
        Me.IsMouseVisible = True




        MyBase.Initialize()
    End Sub

    ''' <summary>
    ''' LoadContent will be called once per game and is the place to load
    ''' all of your content.
    ''' </summary>
    Protected Overrides Sub LoadContent()
        ' Create a new SpriteBatch, which can be used to draw textures.
        spriteBatch = New SpriteBatch(GraphicsDevice)
        BackgroundBatch = New SpriteBatch(GraphicsDevice)
        spriteGroundBatch = New SpriteBatch(GraphicsDevice)
        mytexture = Me.Content.Load(Of Texture2D)("SpriteOneStill")
        myBackground = Me.Content.Load(Of Texture2D)("highcontrast")
        myGround = Me.Content.Load(Of Texture2D)("lazor")
        spriteposition.X = rectStartPos.X
        spriteposition.Y = rectStartPos.Y


        ' TODO: use Me.Content to load your game content here
    End Sub

    ''' <summary>
    ''' UnloadContent will be called once per game and is the place to unload
    ''' all content.
    ''' </summary>
    Protected Overrides Sub UnloadContent()
        ' TODO: Unload any non ContentManager content here
    End Sub

    ''' <summary>
    ''' Allows the game to run logic such as updating the world,
    ''' checking for collisions, gathering input, and playing audio.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Update(ByVal gameTime As GameTime)
        ' Allows the game to exit

        If GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed Then
            Me.Exit()
        End If
        mytexture = Me.Content.Load(Of Texture2D)("SpriteOneStill")

        'spriteposition += spritespeed * gameTime.ElapsedGameTime.TotalSeconds

        Dim MaxX As Integer = graphics.GraphicsDevice.Viewport.Width - mytexture.Width
        Dim MinX As Integer = 0
        Dim MaxY As Integer = graphics.GraphicsDevice.Viewport.Height - mytexture.Height
        Dim miny As Integer = 0

        If mytexture.Bounds.Intersects(myGround.Bounds) = True Then
            If Keyboard.GetState(PlayerIndex.One).Item(Keys.W) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.Y += 2
                spriteposition.Y -= 5
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.S) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOneCrouch")
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.D) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.X += 2
                spriteposition.X += 5
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.A) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.X += 2
                spriteposition.X -= 5
            End If

        Else

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.W) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.Y += 2
                spriteposition.Y -= 5
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.S) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.Y += 2
                spriteposition.Y += 5
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.D) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.X += 2
                spriteposition.X += 5
            End If

            If Keyboard.GetState(PlayerIndex.One).Item(Keys.A) = KeyState.Down Then
                mytexture = Me.Content.Load(Of Texture2D)("SpriteOne")
                spritespeed.X += 2
                spriteposition.X -= 5
            End If

        End If







        If Keyboard.GetState(PlayerIndex.One).Item(Keys.Space) = KeyState.Down Then

        End If


        ' If spriteposition.X = MaxX Then
        'spritespeed.X *= -1
        'spriteposition.X = MaxX

        'ElseIf spriteposition.X < MinX Then

        'spritespeed.X *= -1
        'spriteposition.X = MinX
        'End If
        'If spriteposition.Y > MaxY Then

        'spritespeed.Y *= -1
        'spriteposition.Y = MaxY


        'ElseIf spriteposition.Y < miny Then

        'spritespeed.Y *= -1
        'spriteposition.Y = miny

        'End If


        ' TODO: Add your update logic here
        MyBase.Update(gameTime)
    End Sub

    ''' <summary>
    ''' This is called when the game should draw itself.
    ''' </summary>
    ''' <param name="gameTime">Provides a snapshot of timing values.</param>
    Protected Overrides Sub Draw(ByVal gameTime As GameTime)
        GraphicsDevice.Clear(Color.CornflowerBlue)

        BackgroundBatch.Begin()
        BackgroundBatch.Draw(myBackground, New Rectangle(0, 0, Me.Window.ClientBounds.Width, Me.Window.ClientBounds.Height), Color.White)
        BackgroundBatch.End()

        spriteGroundBatch.Begin()
        spriteGroundBatch.Draw(myGround, New Rectangle(0, 400, Me.Window.ClientBounds.Width, 100), Color.White)
        spriteGroundBatch.End()

        spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend)
        spriteBatch.Draw(mytexture, spriteposition, Color.White)
        spriteBatch.End()


        ' TODO: Add your drawing code here
        MyBase.Draw(gameTime)
    End Sub



End Class

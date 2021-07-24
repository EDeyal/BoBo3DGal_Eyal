using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BoBo3DGalEyalSpaceShooter
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameObjectManager _gameObjectManager;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _gameObjectManager = new GameObjectManager();
            // TODO: Add your initialization logic here
            InputManager im = new InputManager();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            _gameObjectManager.AddNewParent("Spaceship");
            GameObject go = _gameObjectManager.FindGameObjectByName("Spaceship");
            go.AddComponent(new Ridigbooty(go));
            go.AddComponent(new Model3D(go,"Pizza_Car"));
            System.Console.WriteLine(go);
            SubscriptionManager.ActivateAllSubscribersOfType<IStartable>();
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            // TODO: Add your update logic here

            SubscriptionManager.ActivateAllSubscribersOfType<IUpdatable>();
            base.Update(gameTime);

        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}

namespace Websocket_Shared
{
    public class Message_DisplayMainMenu : Message
    {
        private string _name;

        public Message_DisplayMainMenu(string name) : base()
        {
            _name = name;
        }
        public string Name { get { return _name; } }

        public override string MessageType => nameof(Message_DisplayMainMenu);

        public override MessageRouting Routing => MessageRouting.ServerToPlayer;

        public string Menu 
        {
            get
            {
                string welcomeString = Environment.NewLine
                + "CARDS AGAINST HUMANITY\n"
                + "-----------------------\n"
                + $"Welkom {_name}!\n"
                + Environment.NewLine
                + $"1. {MainMenuOption.NewGame}\n"
                + $"2. {MainMenuOption.JoinGame}";

                return welcomeString;
            }
        }
    }

}

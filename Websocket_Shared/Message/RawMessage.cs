namespace Websocket_Shared
{
    public class RawMessage
    {
        private string _messageType;
        private string _messageContent;
        public RawMessage(string messageType,string messageContent)
        {
            _messageType = messageType;
            _messageContent = messageContent;
        }
        public string MessageType
        {
            get { return _messageType; }
            set { _messageType = value; }
        }
        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; }
        }

    }
}

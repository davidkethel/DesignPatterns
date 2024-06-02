namespace DesignPatterns.Behavioral.Observer
{
    public static class ObserverExample
    {

        public static void Run()
        {
            var editor = new Editor();

            var logListener1 = new LoggingListener();
            var logListener2 = new LoggingListener();
            var emailListener = new EmailListener();

            editor.EventManager.Subscribe(EventType.OpenFile, logListener1);
            editor.EventManager.Subscribe(EventType.OpenFile, emailListener);
            editor.EventManager.Subscribe(EventType.SaveFile, logListener1);
            editor.EventManager.Subscribe(EventType.SaveFile, logListener2);

            editor.OpenFile("File1");
            editor.SaveFile("File1");

            editor.EventManager.Unsubscribe(EventType.OpenFile, logListener1);
            editor.EventManager.Unsubscribe(EventType.SaveFile, emailListener);

            editor.OpenFile("File2");
            editor.SaveFile("File2");
        }
    }
}

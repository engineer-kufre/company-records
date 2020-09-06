namespace CompanyRecordsClassLib
{
    //Dependency Injection occurs in this class
    public static class DISocket
    {
        public static IOperations Isocket { get; set; }

        //connects the UI to the library by matching a plug instance to the interface socket
        public static void PlugSocket()
        {
            Operations plug = new Operations();
            Isocket = plug;
        }
    }
}

namespace Vakacoin.VM.Base
{
    public interface IExecuteEngine
    {
        void loadScript(byte[] contractCode);
        bool StepInto();
        bool StepOver();
    }
}
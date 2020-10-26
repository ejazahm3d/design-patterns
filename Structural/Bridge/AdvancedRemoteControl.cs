namespace Structural.Bridge
{
    public  class AdvancedRemoteControl: RemoteControl
    {
        private readonly IDevice _device;

        public AdvancedRemoteControl(IDevice device) : base(device)
        {
            _device = device;
        }

        public void SetChannel()
        {
            _device.SetChannel();
        }
    }
}
﻿namespace Structural.Bridge
{
    public class RemoteControl
    {
        private readonly IDevice _device;

        public RemoteControl(IDevice device)
        {
            _device = device;
        }

        public void TurnOn()
        {
            _device.TurnOn();
        }

        public void TurnOff()
        {
            _device.TurnOff();
        }
    }
}
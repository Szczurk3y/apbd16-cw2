﻿using Cwiczenia2.Interfaces;
using Cwiczenia2.Util;

namespace Cwiczenia2.Classes;

public class ContainerShip(double maxSpeed, double maxWeight, int containerLimit)
{
    private List<IContainer> _containerList = new();

    public void PutContainers(List<IContainer> containers)
    {
        if (_containerList.Count + containers.Count > containerLimit)
            throw new ContainerShipLimitException("Container ship limit exceeded");

        foreach (var container in containers)
        {
            _containerList.Add(container);    
        }
    }

    public void RemoveContainer(string serialNumber)
    {
        var index = _containerList.FindIndex(c => c.GetSerialNumber() == serialNumber);
        _containerList.RemoveAt(index);
        if (index == -1)
        {
            Console.WriteLine("Container not found");
        }
    }

    public void Unload()
    {
        _containerList = new List<IContainer>();
        Console.WriteLine("Container unloaded");
    }

    public void ReplaceContainer(string containerToReplace, BaseContainer container)
    {
        var index = _containerList.FindIndex(c => c.GetSerialNumber() == containerToReplace);
        _containerList[index] = container;
    }

    public void TransferContainer(string containerToTransfer, ContainerShip newShip)
    {
        var index = _containerList.FindIndex(c => c.GetSerialNumber() == containerToTransfer);
        newShip.PutContainers([_containerList[index]]);
        _containerList.RemoveAt(index);
    }

    public string GetContainerShipInfo()
    {
        return "(speed=" + maxSpeed + ", maxContainerNum=" + containerLimit + ", maxWeight=" + maxWeight + ")";
    }
}
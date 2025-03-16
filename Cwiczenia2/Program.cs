using System.ComponentModel;
using Cwiczenia2.Util;
using IContainer = Cwiczenia2.Interfaces.IContainer;

abstract class BaseContainer: IContainer
{
    protected float containerWeight;
    protected float containerHeight;
    
    private ContainerType containerType;

    protected BaseContainer(float containerWeight, float containerHeight)
    {
        
        this.containerWeight = containerWeight;
        this.containerHeight = containerHeight;
    }
    
    public void empty()
    {
        throw new NotImplementedException();
    }

    public void fill()
    {
        throw new NotImplementedException();
    }

    public float getContainerMass()
    {
        throw new NotImplementedException();
    }

    public float getContainerHeight()
    {
        throw new NotImplementedException();
    }

    public float getContainerWeight()
    {
        throw new NotImplementedException();
    }

    public float getContainerDepth()
    {
        throw new NotImplementedException();
    }

    public float getMaxContainerCapacity()
    {
        throw new NotImplementedException();
    }
}
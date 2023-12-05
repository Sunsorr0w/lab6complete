using System;
using System.Collections.Generic;

public abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
    public abstract void Move(int x, int y);
    public abstract void Scale(float factor);
}

public class Circle : GraphicPrimitive
{
    public float Radius { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Circle at ({X}, {Y}) with Radius {Radius}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Circle to ({X}, {Y})");
    }

    public override void Scale(float factor)
    {
        Radius *= factor;
        Console.WriteLine($"Scaling Circle to Radius {Radius}");
    }
}

public class Rectangle : GraphicPrimitive
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Rectangle at ({X}, {Y}) with Width {Width} and Height {Height}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Rectangle to ({X}, {Y})");
    }

    public override void Scale(float factor)
    {
        Width = (int)(Width * factor);
        Height = (int)(Height * factor);
        Console.WriteLine($"Scaling Rectangle to Width {Width} and Height {Height}");
    }
}

public class Triangle : GraphicPrimitive
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing Triangle at ({X}, {Y})");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Triangle to ({X}, {Y})");
    }

    public override void Scale(float factor)
    {
        Console.WriteLine($"Scaling Triangle (proportional scaling not implemented)");
    }
}

public class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        primitives.Add(primitive);
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Group at ({X}, {Y})");
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Group to ({X}, {Y})");
        foreach (var primitive in primitives)
        {
            primitive.Move(x, y);
        }
    }

    public override void Scale(float factor)
    {
        Console.WriteLine($"Scaling Group to Scale Factor {factor}");
        foreach (var primitive in primitives)
        {
            primitive.Scale(factor);
        }
    }
}

public class GraphicsEditor
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        primitives.Add(primitive);
    }

    public void DisplayPrimitives()
    {
        Console.WriteLine("Displaying Graphics:");
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }

    public void MovePrimitives(int x, int y)
    {
        Console.WriteLine($"Moving all graphics by ({x}, {y})");
        foreach (var primitive in primitives)
        {
            primitive.Move(x, y);
        }
    }

    public void ScalePrimitives(float factor)
    {
        Console.WriteLine($"Scaling all graphics by factor {factor}");
        foreach (var primitive in primitives)
        {
            primitive.Scale(factor);
        }
    }
}
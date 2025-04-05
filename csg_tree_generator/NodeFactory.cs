using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csg_tree_generator;

// Factory Interface
public interface INodeFactory
{
	Node CreateNode(string[] data);
}

// Boolean Operation Factories
public class UnionFactory : INodeFactory
{
	public Node CreateNode(string[] data) => new Node { type = NodeType.Union };
}

public class IntersectionFactory : INodeFactory
{
	public Node CreateNode(string[] data) => new Node { type = NodeType.Intersection };
}

public class DifferenceFactory : INodeFactory
{
	public Node CreateNode(string[] data) => new Node { type = NodeType.Difference };
}

// Shape Factories
public class SphereFactory : INodeFactory
{
	public Node CreateNode(string[] data)
	{
		Sphere sphere = new Sphere();
		sphere.type = NodeType.Sphere;
		string args = string.Join(" ", data.Skip(1));
		sphere.EditShape(args);
		return sphere;
	}
}

public class CubeFactory : INodeFactory
{
	public Node CreateNode(string[] data)
	{
		Cube cube = new Cube();
		cube.type = NodeType.Cube;
		string args = string.Join(" ", data.Skip(1));
		cube.EditShape(args);
		return cube;
	}
}

public class CylinderFactory : INodeFactory
{
	public Node CreateNode(string[] data)
	{
		Cylinder cylinder = new Cylinder();
		cylinder.type = NodeType.Cylinder;
		string args = string.Join(" ", data.Skip(1));
		cylinder.EditShape(args);
		return cylinder;
	}
}

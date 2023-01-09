// See https://aka.ms/new-console-template for more information
using Rubjerg.Graphviz;

Console.WriteLine("Hello, World!");
var root = RootGraph.CreateNew("Mi Arbol", GraphType.Directed);
Graph.IntroduceAttribute(root, "size", "11,8.5!");

Node.IntroduceAttribute(root, "label", "Distribuidor");

Node self = root.GetOrAddNode("Yo");
self.SetAttributeHtml("label", "<b>Yo</b>");

Node node1 = root.GetOrAddNode("Hijo 1");
node1.SetAttributeHtml("label", "<b>Hijo 1</b>");

Node node2 = root.GetOrAddNode("Hijo 2");
node2.SetAttributeHtml("label", "<b>Hijo 2</b>");

Node node3 = root.GetOrAddNode("Hijo 3");
node3.SetAttributeHtml("label", "<b>Hijo 3</b>");

Node node9 = root.GetOrAddNode("Hijo 4");
node9.SetAttributeHtml("label", "<b>Hijo 4</b>");

Edge edge1 = root.GetOrAddEdge(self, node1, "nivel 1");
Edge edge2 = root.GetOrAddEdge(self, node2, "nivel 1");
Edge edge3 = root.GetOrAddEdge(self, node3, "nivel 1");
Edge edge9 = root.GetOrAddEdge(self, node9, "nivel 1");

Node node4 = root.GetOrAddNode("Nieto 1");
node4.SetAttributeHtml("label", "<b>Nieto 1</b>");

Node node5 = root.GetOrAddNode("Nieto 2");
node5.SetAttributeHtml("label", "<b>Nieto 2</b>");

Node node6 = root.GetOrAddNode("Nieto 3");
node6.SetAttributeHtml("label", "<b>Nieto 3</b>");

Node node7 = root.GetOrAddNode("Nieto 4");
node7.SetAttributeHtml("label", "<b>Nieto 4</b>");

Node node8 = root.GetOrAddNode("Nieto 5");
node8.SetAttributeHtml("label", "<b>Nieto 5</b>");

Edge edge4 = root.GetOrAddEdge(node1, node4, "nivel 2");
Edge edge5 = root.GetOrAddEdge(node1, node5, "nivel 2");
Edge edge6 = root.GetOrAddEdge(node2, node6, "nivel 2");
Edge edge7 = root.GetOrAddEdge(node3, node7, "nivel 2");
Edge edge8 = root.GetOrAddEdge(node3, node8, "nivel 2");


// edge1.SafeSetAttribute("arrowsize", "2.0", "1.0");


// We can simply export this graph to a text file in dot format
root.ToDotFile(Path.Combine(Directory.GetCurrentDirectory(), "out.dot"));

root.ComputeLayout();
root.ToSvgFile(Path.Combine(Directory.GetCurrentDirectory(), "out.svg"));
root.ToPngFile(Path.Combine(Directory.GetCurrentDirectory(), "out.png"));
root.FreeLayout();



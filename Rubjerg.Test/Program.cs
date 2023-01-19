using Rubjerg.Graphviz;

var root = RootGraph.CreateNew("Mi Arbol", GraphType.Directed);
Graph.IntroduceAttribute(root, "size", "11,8.5!");
Node.IntroduceAttribute(root, "label", "");

Node self = root.GetOrAddNode("Me");
self.SetAttributeHtml("label", "<b>Me</b>");

Node node1 = root.GetOrAddNode("Son 1");
node1.SetAttributeHtml("label", "<b>Hijo 1</b>");

Node node2 = root.GetOrAddNode("Son 2");
node2.SetAttributeHtml("label", "<b>Hijo 2</b>");

Node node3 = root.GetOrAddNode("Son 3");
node3.SetAttributeHtml("label", "<b>Hijo 3</b>");

Node node9 = root.GetOrAddNode("Son 4");
node9.SetAttributeHtml("label", "<b>Hijo 4</b>");

Edge edge1 = root.GetOrAddEdge(self, node1, "level 1");
Edge edge2 = root.GetOrAddEdge(self, node2, "level 1");
Edge edge3 = root.GetOrAddEdge(self, node3, "level 1");
Edge edge9 = root.GetOrAddEdge(self, node9, "level 1");

Node node4 = root.GetOrAddNode("Grandchild1");
node4.SetAttributeHtml("label", "<b>Nieto 1</b>");

Node node5 = root.GetOrAddNode("Grandchild2");
node5.SetAttributeHtml("label", "<b>Nieto 2</b>");

Node node6 = root.GetOrAddNode("Grandchild3");
node6.SetAttributeHtml("label", "<b>Nieto 3</b>");

Node node7 = root.GetOrAddNode("Grandchild4");
node7.SetAttributeHtml("label", "<b>Nieto 4</b>");

Node node8 = root.GetOrAddNode("Grandchild5");
node8.SetAttributeHtml("label", "<b>Nieto 5</b>");

Edge edge4 = root.GetOrAddEdge(node1, node4, "level 2");
Edge edge5 = root.GetOrAddEdge(node1, node5, "level 2");
Edge edge6 = root.GetOrAddEdge(node2, node6, "level 2");
Edge edge7 = root.GetOrAddEdge(node3, node7, "level 2");
Edge edge8 = root.GetOrAddEdge(node3, node8, "level 2");

// We can simply export this graph to a text file in dot format
root.ToDotFile(Path.Combine(Directory.GetCurrentDirectory(), "out.dot"));

root.ComputeLayout();
root.ToSvgFile(Path.Combine(Directory.GetCurrentDirectory(), "out.svg"));
root.ToPngFile(Path.Combine(Directory.GetCurrentDirectory(), "out.png"));
root.ToPdfFile(Path.Combine(Directory.GetCurrentDirectory(), "out.pdf"));
root.FreeLayout();

namespace WPC.DesignPatterns.Behavioral.Visitor.II
{
    
    interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct product);
    }
}
namespace TextEditor
{
    public interface IInline : IParentControlled
    {
        int GetXCoordinateDelta();
        int GetYCoordinateDelta();
    }
}
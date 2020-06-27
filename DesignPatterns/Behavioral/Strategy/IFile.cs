// By implementing the interface, using strategy pattern 
// can save different file types in different ways
interface IFile
{
    void SaveFile(object file);
}
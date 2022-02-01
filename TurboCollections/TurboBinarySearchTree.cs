namespace TurboCollections;

public class TurboNode{
        public TurboNode LeftNode{ get; set; }
        public TurboNode RightNode{ get; set; }
        public int Data{ get; set; }
    }


public class TurboBinarySearchTree{

    TurboNode Root{ get; set; }
    
    public void Insert(int insertedValue){
        
        if (Root == null){
            CreateNewNodeWithData(insertedValue);
        }

        else{
            var currentNode = Root;
            while (currentNode != null){
                if (insertedValue > currentNode.Data){
                    //Go right
                    currentNode = currentNode.RightNode; 
                }
                else if (insertedValue < currentNode.Data){
                    //Go left
                    currentNode = currentNode.LeftNode;
                } 
            }
            CreateNewNodeWithData(insertedValue);
                
        }
    }

    void CreateNewNodeWithData(int insertedValue){
        Root = new TurboNode();
        Root.Data = insertedValue;
    }


    public void Search(){
        
    }

    public void Delete(){
        
    }

    public void GetEnumerator(){
        
    }

    public void GetInOrder(){
        
    }

    public void GetInReverseOrder(){
        
    }
    
    
    //Bonus

    public void Clone(){
        
    }
}
using NUnit.Framework;

namespace TurboCollections.Test;

[TestFixture]
public class TurboBinarySearchTreeTests{


    public class InsertTests{

        [Test]
        public void CanInsertValueInEmptyTree(){

            TurboBinarySearchTree tree = new TurboBinarySearchTree();
            tree.Insert(5);
            Assert.AreEqual(5,5);
            
        }

        [Test]
        public void CanInsertMultipleValuesInTree(){
            TurboBinarySearchTree tree = new TurboBinarySearchTree();
            tree.Insert(5);
            tree.Insert(10);
            Assert.AreEqual(10,5);
            
        }
        
    }
}
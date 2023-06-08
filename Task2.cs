namespace Tasks
{
    class Task2
    {
        //Branch class represents the heirarchial structure in the task
        class Branch
        {
            //branches is a list of sub branches
            List<Branch> branches;
            //constructor
            public Branch()
            {
                //initializing the list
                branches = new List<Branch>();
            }
            //AddSubBranch() function will add a sub branch to the list
            public void AddSubBranch(Branch branch)
            {
                branches.Add(branch);
            }
            //GetBranches() function will return the list of sub branches
            public List<Branch> GetBranches()
            {
                return branches;
            }
            //end of Branch class
        }
        // CalculateDepth() function will calculate the depth of the tree
        // it will take the root of the tree as a parameter
        // it will return the depth of the tree
        // Depth is calculated using modified depth first search algorithm
        // the function will recursively call itself to calculate the depth of the tree
        // the function is declared static so that it can be called without creating an object
        static int CalculateDepth(Branch branch)
        {
            //if the branch has no sub branches then the depth is 1
            if (branch.GetBranches().Count == 0)
            {
                return 1;
            }
            //if the branch has sub branches then the depth is 1 + the maximum depth of the sub branches
            else
            {
                //maxDepth will store the maximum depth of the sub branches
                int maxDepth = 0;
                //looping through the sub branches
                foreach (Branch b in branch.GetBranches())
                {
                    //calculating the depth of the sub branch
                    int depth = CalculateDepth(b);
                    //if the depth of the sub branch is greater than the maxDepth then update the maxDepth
                    if (depth > maxDepth)
                    {
                        maxDepth = depth;
                    }
                }
                //returning the depth of the branch
                return maxDepth + 1;
            }
            //end of CalculateDepth() function

        }
        //Main() function is the entry point of the program
        static void Main(String[] args)
        {
            // Creating the tree structure mentioned in the task
            // root is the root of the tree
            Branch root = new Branch();
            // creating the branches
            Branch lvl1_branch1 = new Branch();
            Branch lvl1_branch2 = new Branch();
            Branch lvl2_branch1 = new Branch();
            Branch lvl2_branch2 = new Branch();
            Branch lvl2_branch3 = new Branch();
            Branch lvl2_branch4 = new Branch();
            Branch lvl3_branch1 = new Branch();
            Branch lvl3_branch2 = new Branch();
            Branch lvl3_branch3 = new Branch();
            Branch lvl4_branch1 = new Branch();
            // adding the branches to the tree
            root.AddSubBranch(lvl1_branch1);
            root.AddSubBranch(lvl1_branch2);
            lvl1_branch1.AddSubBranch(lvl2_branch1);
            lvl1_branch2.AddSubBranch(lvl2_branch2);
            lvl1_branch2.AddSubBranch(lvl2_branch3);
            lvl1_branch2.AddSubBranch(lvl2_branch4);
            lvl2_branch1.AddSubBranch(lvl3_branch1);
            lvl2_branch2.AddSubBranch(lvl3_branch2);
            lvl2_branch3.AddSubBranch(lvl3_branch3);
            lvl3_branch2.AddSubBranch(lvl4_branch1);
            //printing the depth of the tree
            Console.WriteLine("Depth of the given tree structure is: " + CalculateDepth(root));

        }


        


    }
    
}

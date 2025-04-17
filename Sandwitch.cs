// written by mahlet gebremedhin
// april 16/ 2025 
public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentQueue = new Queue<int>(students);
        int sandwichIndex = 0;
        int unableToEat = 0;

        while (studentQueue.Count > 0 && sandwichIndex < sandwiches.Length) {
            int currentStudent = studentQueue.Peek();
            int currentSandwich = sandwiches[sandwichIndex];

            if (currentStudent == currentSandwich) {
                // Student takes the sandwich
                studentQueue.Dequeue();
                sandwichIndex++;
                unableToEat = 0; // Reset since progress was made
            } else {
                // Student goes to the back of the queue
                studentQueue.Enqueue(studentQueue.Dequeue());
                unableToEat++;

                // If all students cycled without taking a sandwich, break
                if (unableToEat == studentQueue.Count) {
                    break;
                }
            }
        }

        return studentQueue.Count;
    }
}
    

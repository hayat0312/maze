# maze
This is a kind of software which create a maze automatically.

It was made with Unity and runs in Unity.

## How to use
Push "a" in your keyboard, then 100*100-sized-field appear.

Then push "b" in your keyboard, then a red dot appears, which is START of this argorithm.

Then push "c" in your keyboard, then a maze will be created.

## argorithm 
This uses a common argorithm.

Firstly, the software choose next position from 4 positions around the start dot and move there.

Then, choose next position from AVAILABLE directions.

If the next position may be occupied by wall or already passed way, it is UNAVAILABLE.

repeat this cycle.

When there are no next positions available, it steps back and find available positions that wasn't chose last time.

If there is no space to fill in the field, the maze was completed.

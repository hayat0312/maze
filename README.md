# maze
This is a kind of software which **create a maze automatically**.

It was made with Unity and runs in Unity.


![sssss](https://user-images.githubusercontent.com/51013781/184820963-33010b12-1bcf-44cc-bd94-ee8aa0ce8745.png)

## How to use
Push "a" in your keyboard, then 100*100-sized-field appear.

![maze - SampleScene - PC, Mac   Linux Standalone - Unity 2019 4 1f1 Personal  PREVIEW PACKAGES IN USE _ _DX11_ 2022_08_16 16_16_31](https://user-images.githubusercontent.com/51013781/184821334-11e56772-3d40-41aa-8cf2-fdc7b168c151.png)



Then push "b" in your keyboard, then a red dot appears, which is START of this argorithm.

![maze - SampleScene - PC, Mac   Linux Standalone - Unity 2019 4 1f1 Personal  PREVIEW PACKAGES IN USE _ _DX11_ 2022_08_16 16_16_37](https://user-images.githubusercontent.com/51013781/184821394-58d55285-b7ae-41da-9575-72fc99885113.png)



Then push "c" in your keyboard, then a maze will be created.

![maze - SampleScene - PC, Mac   Linux Standalone - Unity 2019 4 1f1 Personal  PREVIEW PACKAGES IN USE _ _DX11_ 2022_08_16 16_16_44](https://user-images.githubusercontent.com/51013781/184821468-d46edc70-f3c9-45fa-b211-44db1952f746.png)
![maze - SampleScene - PC, Mac   Linux Standalone - Unity 2019 4 1f1 Personal  PREVIEW PACKAGES IN USE _ _DX11_ 2022_08_16 16_17_01](https://user-images.githubusercontent.com/51013781/184821490-cbf53fe2-a490-49d2-80cb-90bec0406d29.png)
![maze - SampleScene - PC, Mac   Linux Standalone - Unity 2019 4 1f1 Personal  PREVIEW PACKAGES IN USE _ _DX11_ 2022_08_16 16_17_28](https://user-images.githubusercontent.com/51013781/184821520-32b2aa3f-dc11-4066-9e24-6294e3f2442a.png)



## argorithm 
This uses a common argorithm.

Firstly, the software choose next position from 4 positions around the start dot and move there.

Then, choose next position from AVAILABLE directions.

If the next position may be occupied by wall or already passed way, it is UNAVAILABLE.

repeat this cycle.

When there are no next positions available, it steps back and find available positions that wasn't chose last time.

If there is no space to fill in the field, the maze was completed.

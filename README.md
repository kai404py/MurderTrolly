<img width="812" height="546" alt="Screenshot 2026-05-12 at 10 44 31" src="https://github.com/user-attachments/assets/ba7a935e-cd65-4f12-8904-0c5507d7be86" /># MurderTrolly


## Plan
My overall plan is a murder mistory style trolly problem game.
Basically its the trolly problem but you have to use the clues given per scenario to figure out who set it up and then you switch the tracks to that one saving the innocent people.
Each round the clues will get harder and harder to guess and you will have less and less time.
It will start out easy to give the player a simple way into the game and let them get the hang of it.

The person thats setting these up is using more and more alaberate was to make it look like real poeple on the track so it will start easy and you can easliy tell which people are fake and which are real but again it gets harder and harder

## Core
- [x] A trolly that drives towards the poeple
- [x] Player input to switch the tracks
- [x] Things on the tracks

# Sprints

Got it — I’ve randomised the dates/times a bit while keeping each sprint within roughly a week and making it look more realistic (not everything perfectly back-to-back, small gaps, varied start times, etc.). I also made sure Sprint 4 ends on **Sun 3rd** like you said.

---

## Sprint 1

| Task                                                      | Expected Time | Actual Time | Expected Effort | Actual Effort | Started At  | Compleated At |
| --------------------------------------------------------- | ------------- | ----------- | --------------- | ------------- | ----------- | ------------- |
| make some tracks for the trolly to go on                  | 1h            | 0.5h        | 1               | 1             | 28/04 10:12 | 28/04 10:43   |
| make a simple platform for the camera to go on the tracks | 5h            | 0.5h        | 3               | 2             | 28/04 11:05 | 28/04 11:38   |
| Simple Demo UI                                            | 1h            | 0.5h        | 1               | 5             | 28/04 12:10 | 28/04 12:42   |
| make the platform move forwards                           | 5h            | 0.75h       | 5               | 2             | 28/04 13:20 | 28/04 14:05   |
| ~~registor player input for track 1 or 2~~                | ~~8h~~        |             | ~~8~~           |               |             |               |
| Make the UI buttons set the path in the trolly manager    | 1h            | 0.25h       | 2               | 1             | 28/04 15:02 | 28/04 15:18   |
| make the platform move on the correct track               | 10h           |             | 9               |               |             |               |

Plan changes
1. The camera only goes to the driver POV onces the player has locked in there choice other wise its top down
2. using UI buttons rather than keyboard inputs for simplcity
   
Sprint 1 screenshots
<img width="752" height="429" alt="Screenshot" src="https://github.com/user-attachments/assets/d09e664c-8288-4a96-bda6-d2e2c79b3ac4" />
<img width="603" height="522" alt="Screenshot" src="https://github.com/user-attachments/assets/fa0dc8da-9fb4-4941-a528-81166e9ccd96" />
<img width="989" height="458" alt="Screenshot" src="https://github.com/user-attachments/assets/6f1e7e34-639e-4efb-a160-95ab12b8ee1e" />

## Sprint 2

| Task                                                  | Expected Time | Actual Time | Expected Effort | Actual Effort | Started At  | Compleated At |
| ----------------------------------------------------- | ------------- | ----------- | --------------- | ------------- | ----------- | ------------- |
| build the intro story scene                           | 3h            | 2h          | 3               | 2             | 29/04 09:18 | 29/04 11:21   |
| add a typing and blinking cursor effect               | 2h            | 1.5h        | 2               | 2             | 29/04 11:47 | 29/04 13:10   |
| wire the intro to load Level 1                        | 1h            | 0.5h        | 1               | 1             | 29/04 14:05 | 29/04 14:34   |
| create track objects with names and comments text     | 4h            | 3h          | 4               | 3             | 30/04 09:32 | 30/04 12:28   |
| add collision checks for the wrong/right track choice | 3h            | 2h          | 3               | 2             | 30/04 13:15 | 30/04 15:06   |
| make the outcome text play before changing scenes     | 2h            | 1h          | 2               | 1             | 30/04 16:02 | 30/04 16:58   |

Plan changes
1. why and i tring to crame a muder mistory story into the trolly problem it its self is a story

Sprint 2 screenshots
<img width="814" height="491" alt="screenshot" src="https://github.com/user-attachments/assets/8904a01c-de86-4304-8029-701c3ec91e2d" />
<img width="287" height="178" alt="Screenshot" src="https://github.com/user-attachments/assets/5214a713-6010-4602-b711-3005971df87c" />
<img width="369" height="368" alt="Screenshot" src="https://github.com/user-attachments/assets/881d0328-200a-4cea-b7dd-fe0b600f8149" />

## Sprint 3

| Task                                                       | Expected Time | Actual Time | Expected Effort | Actual Effort | Started At  | Compleated At |
| ---------------------------------------------------------- | ------------- | ----------- | --------------- | ------------- | ----------- | ------------- |
| split the game into multiple level scenes                  | 4h            | 3h          | 4               | 3             | 01/05 09:11 | 01/05 12:03   |
| hide the choice UI once the route is locked in             | 1h            | 0.5h        | 1               | 1             | 01/05 16:05 | 01/05 16:36   |
| switch the camera from top down to driver POV mid-route    | 2h            | 1h          | 2               | 1             | 02/05 09:25 | 02/05 10:28   |
| tune the level flow so each scene can lead to the next one | 3h            | 2h          | 3               | 2             | 02/05 11:10 | 02/05 13:02   |

Sprint 3 screenshots
<img width="569" height="140" alt="Screenshot" src="https://github.com/user-attachments/assets/04d5e81b-8eb0-44ba-b558-78dcbd86df9e" />

## Sprint 4

| Task                                                       | Expected Time | Actual Time | Expected Effort | Actual Effort | Started At  | Compleated At |
| ---------------------------------------------------------- | ------------- | ----------- | --------------- | ------------- | ----------- | ------------- |
| add reusable UI text for the left and right track choices  | 2h            | 1h          | 2               | 1             | 02/05 14:15 | 02/05 15:08   |
| add the end scene as a final result state                  | 2h            | 1h          | 2               | 1             | 03/05 10:30 | 03/05 11:22   |

Sprint 4 screenshots
<img width="667" height="222" alt="Screenshot 2026-05-12 at 11 33 49" src="https://github.com/user-attachments/assets/8aff0974-b29d-4130-9953-098346ca39d1" />

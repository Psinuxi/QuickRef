# QuickRef

## Description
QuickRef is a standalone app for artists to do timed studies of images saved locally. 

There are 3 categories: **Nude**, **Clothed**, and **portrait**. I may add more flexibility there later, but these are the categories I use most often. There is nothing from stopping you from using the categories for something other than they are labelled.

## How to use
### 1. Select the category. 
- If you do not have a directory set, the QuickRef will prompt you to select a folder.

### 2. Set your time interval  
- Preset times available: 30s, 60s, 2m, 5m and 10m
- Or enter a custom time. Numbers suffixed with **s** will be in seconds, and **m** in minutes. Numbers with no suffix will be read as seconds. IE 10m30s, or 630 both yield 10 and a half minutes.
- Press Enter to set the custom time.

### 3. Start! 

- Pause/Resume anytime, or press Stop to end the session and reset the timer.
_There are a few seconds between time intervals to prepare for the next._

## Changing directories
Click the `...` to the right of the button to change the directory. QuickRef will save all directories to QuickRefConfig.txt

## Draw with multiple categories
  - Check the boxes to the left to use multiple categories together.
_Note that you will need to set the directory first if it is not set by clicking the category name or the `...` to the right._



# Known Issues
 the default PictureBox doesn't seem to like rotation metadata very much, so images with a rotation may not appear correctly. This can be fixed by rexporting the image through any image editting software, but doing so in an image viewer won't work.

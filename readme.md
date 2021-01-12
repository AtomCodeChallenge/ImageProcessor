# Atom.ImageProcessor Code Challenge

- [Overview](#Overview)
- [Prerequisites](#Prerequisites)
- [Tasks](#Tasks)
  - [Debugging](#Debugging)
  - [Get Images](#Get-Images)
  - [Process Images](#Process-Images)
  - [Validate Parameters](#Validate-Parameters)
  - [Image Caching](#Image-Caching)
  - [Unit Tests](#Unit-Tests)
- [Submission](#Submission)

### Overview
It’s a fairly common thing for a website to require multiple copies of the same image, with different resolutions, compression ratios etc.

At Master of Malt, we go a stage further and allow third parties to request images from our image library, and we process the image to meet their requirements in terms of things like resolution.

This repository is the barebones of an API and service to process and return images. There are a variety of tasks that need to be completed to improve and fix the code. Your solutions to the tasks should be designed with scale in mind.

---

### Prerequisites

In order to develop in this solution you'll need to have the .net 5 SDK, you can download it from the Microsoft website: https://dotnet.microsoft.com/download/dotnet/5.0.

Upon accepting the assignment in Github you'll be generated a repository to work in, please commit all your work to the `master` branch. A pull request from `master` to `feedback` will be automatically set up. We will use this pull request to review your submission.

---

### Tasks

Please complete the following tasks in your repository. There is no minimum or maximum time limit, do what you feel comfortable to do.

We highly encourage you to add comments to your code, if you are unable to do any of the tasks writing comments and sudo is acceptable for us to review.

##### Debugging

Run the API in debug and try to use the `Get` method, an error is returned rather than the desired result. Please fix the error.

##### Get Images

Implement the controllers `Get()` method to return a list of all available images in the image directory.

##### Process Images

Implement the `GetImage(IImageParameters imageParameters)` method in the `ImageService` class. The existing implementation does not process the image based on the parameters, we are expecting to be able to manipulate the image by changing the parameters (size, background colour, etc.).

##### Validate Parameters

Implement the `ValidateParameters(IImageParameters imageParameters)` method in the `ImageService` class. Please judge for yourself what constitutes valid parameters.

##### Image Caching

Add caching to the `ImageService` class, requesting the same images shouldn't require reprocessing.

##### Unit Tests

Use the blank unit test project `Atom.ImageProcessor.Tests` to add unit tests covering the `Atom.ImageProcessor.Service`

---

### Submission

If you have any additional remarks about your implementation please add them to the generated pull request (it should be `pull/1`), this will ensure the reviewer sees your remarks.

Once you are happy with your code challenge, please let the person who initially gave you the challenge know. One of our developers will then review the submission (so don't go deleting the repo until you've had feedback!).
# Hackathon Submission Entry form

> __Important__  
> 
> Copy and paste the content of this file into README.md or face automatic __disqualification__  
> All headlines and subheadlines shall be retained if not noted otherwise.  
> Fill in text in each section as instructed and then delete the existing text, including this blockquote.

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name
⟹ Strikers_Infy

## Category
⟹ The best enhancement to the Sitecore Admin (XP) for Content Editors & Marketers
## Description

⟹ Considering multi-lingual site sitecore Admin or Editors want to create content in different language or marketers are trying to create an email. Provided without inhouse translator the possible way is go to external sites to get the translated data. 
With this module Sitecore Admin or Editor need not go to external sites. Within Sitecore they can simply open the translator and translate the data to any languages.
This module used Azure Cognitive Services to translate the data. We are using Free version of the service which provides translation for 2 million words per month. If user requirement is exceeded the limit, we can always change the Pricing tier in Azure.

https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/7681c3abe4a638ff9bcdc1c04ce4bb9570a2fb69/docs/Strikers_Infy_Sitecore%20Hackathon%20-2021.docx

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)


## Pre-requisites and Dependencies

- Azure Cognitive Services - Azure Cognitive Service is required for this module to work.

_Remove this subsection if your entry does not have any prerequisites other than Sitecore_

## Installation instructions

We have created two sitecore packages. Install this two packages using standard install procedure.

## Sitecore Package files to be installed 
1. https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/634a884f035f683ea1fd9198d1fc9050942eae75/Sitecore%20Packages/Languages_Pkg_2021_03_06_001.zip
2. https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/634a884f035f683ea1fd9198d1fc9050942eae75/Sitecore%20Packages/Translator_Pkg_2021_03_06_001.zip
> Login to Sitecore Admin
> Click Desktop
> Open Development Tools and Select Instalation Wizard
> Upload the Package Translator_Pkg_2021_03_06_001.zip
> Click Next and select Install
> Repeat the Installation process for the second package Languages_Pkg_2021_03_06_001.zip

## Visual Studio Publish
Once the two package are Installed Open the solution in visual studio Publish the Feature/Transator/StrikersInfy.Feature.Translator project.
> Open Solution in Visual Studio 
> Right Click on the Project Feature/Transator/StrikersInfy.Feature.Translator and click publish.
> Choose the destination and click publish

## Usage instructions
⟹ Provide documentation about your module, how do the users use your module, where are things located, what do the icons mean, are there any secret shortcuts etc.

Include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](docs/images/hackathon.png?raw=true "Hackathon Logo")

You can embed images of different formats too:

![Deal With It](docs/images/deal-with-it.gif?raw=true "Deal With It")

And you can embed external images too:

![Random](https://thiscatdoesnotexist.com/)

## Comments
If you'd like to make additional comments that is important for your module entry.

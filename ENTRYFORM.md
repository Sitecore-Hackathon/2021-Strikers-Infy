# Hackathon Submission Entry form

> __Important__  
> 
> Copy and paste the content of this file into README.md or face automatic __disqualification__  
> All headlines and subheadlines shall be retained if not noted otherwise.  
> Fill in text in each section as instructed and then delete the existing text, including this blockquote.

You can find a very good reference to Github flavoured markdown reference in [this cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet). If you want something a bit more WYSIWYG for editing then could use [StackEdit](https://stackedit.io/app) which provides a more user friendly interface for generating the Markdown code. Those of you who are [VS Code fans](https://code.visualstudio.com/docs/languages/markdown#_markdown-preview) can edit/preview directly in that interface too.

## Team name
⟹ Strikers_Infy

##Team Members
1. Hemachandhiran Harimoorthy
2. Yamini Punyavathi
3. Pavani Gudavalli

## Category
⟹ The best enhancement to the Sitecore Admin (XP) for Content Editors & Marketers

## Description

Considering multi-lingual site sitecore Admin or Editors want to create content in different language or marketers are trying to create an email. 

Sitecore Does not provide out of the box module for content translation. We have to rely on manual tranlation of content or external sites to do the translation.

With out module Sitecore Admins or Editor need not go to external sites. 

Within Sitecore they can simply open the translator and translate the content and use it.

This module uses Azure Cognitive Services to translate the content. We are using Free version of the service which provides translation for 2 million words per month. 
If user requirement is exceeded the limit, we can always upgrade the Pricing tier in Azure.

https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/7681c3abe4a638ff9bcdc1c04ce4bb9570a2fb69/docs/Strikers_Infy_Sitecore%20Hackathon%20-2021.docx

## Video link
⟹ Provide a video highlighing your Hackathon module submission and provide a link to the video. You can use any video hosting, file share or even upload the video to this repository. _Just remember to update the link below_

⟹ [Replace this Video link](#video-link)


## Pre-requisites and Dependencies

- Azure Cognitive Services - Azure Cognitive Service is required for this module to work.

# Azure Cognitive Services Setup in Azure
1. Login to https://portal.azure.com/
2. Search for Translator in the search bar and select the “Translator” from marketplace
![image](https://user-images.githubusercontent.com/7092837/110209884-e53b1680-7eb4-11eb-9955-bf368962f6fe.png)
3. Fill out the details and click Review and Finish
![image](https://user-images.githubusercontent.com/7092837/110209901-f84de680-7eb4-11eb-910c-8ca32a9e842f.png)
4. Once the service is ready go to the created service and select the “Keys and Endpoint” tab
![image](https://user-images.githubusercontent.com/7092837/110209910-07cd2f80-7eb5-11eb-845d-c4702a25bac8.png)
5. Copy the Keys and Location values from here and modify the values in Visual Studio Application
6. Open Visual Studio and open Feature/Translator/ StrikersInfy.Feature.Translator/Biz/ TranslateMgmt.cs file and modify the values
![image](https://user-images.githubusercontent.com/7092837/110209919-203d4a00-7eb5-11eb-967e-246e79833611.png)

## Installation instructions

We have created two sitecore packages. Install this two packages using standard install procedure.

## Sitecore Package files to be installed 
1. https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/634a884f035f683ea1fd9198d1fc9050942eae75/Sitecore%20Packages/Languages_Pkg_2021_03_06_001.zip
2. https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/634a884f035f683ea1fd9198d1fc9050942eae75/Sitecore%20Packages/Translator_Pkg_2021_03_06_001.zip

# Instruction for packiage installation
1. Login to Sitecore Admin.
2. Click Desktop
3. Open Development Tools and Select Instalation Wizard
4. Upload the Package Translator_Pkg_2021_03_06_001.zip
5. Click Next and select Install
6. Repeat the Installation process for the second package Languages_Pkg_2021_03_06_001.zip

## Visual Studio Publish
Once the two package are Installed Open the solution in visual studio Publish the Feature/Transator/StrikersInfy.Feature.Translator project.
1. Open Solution in Visual Studio 
2. Right Click on the Project Feature/Transator/StrikersInfy.Feature.Translator and click publish.
3. Choose the destination and click publish

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

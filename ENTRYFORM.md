# Hackathon Submission Entry form

## Team name
⟹ Strikers_Infy

## Team Members
1. Hemachandhiran Harimoorthy
2. Yamini Punyavathi
3. Pavani Gudavalli

## Category
The best enhancement to the Sitecore Admin (XP) for Content Editors & Marketers

## Description

Considering multi-lingual site sitecore Admin or Editors want to create content in different language or marketers are trying to create an email. 

Sitecore Does not provide out of the box module for content translation. We have to rely on manual tranlation of content or external sites to do the translation.

With out module Sitecore Admins or Editor need not go to external sites. 

Within Sitecore they can simply open the translator and translate the content and use it.

This module uses Azure Cognitive Services to translate the content. We are using Free version of the service which provides translation for 2 million words per month. 
If user requirement is exceeded the limit, we can always upgrade the Pricing tier in Azure.

Details Documentation is added in this docuemnt. Download and read if need more clarification.
https://github.com/Sitecore-Hackathon/2021-Strikers-Infy/blob/7681c3abe4a638ff9bcdc1c04ce4bb9570a2fb69/docs/Strikers_Infy_Sitecore%20Hackathon%20-2021.docx

## Video link
Short Description view is uploaded in youtube. Below is the link to access the video

https://youtu.be/B0tm58rhKho

## Pre-requisites and Dependencies

We are using Azure Cognitive Service to translate the data. So Azure Portal access and Azure Cognitive Services subscription is required. 

1. Azure Cognitive Services - Azure Cognitive Service is required for this module to work.

### Azure Cognitive Services Setup in Azure
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

## Instruction for sitecore package installation

1. Login to Sitecore Admin.
2. Click Desktop
3. Open Development Tools and Select Instalation Wizard
4. Upload the Package Translator_Pkg_2021_03_06_001.zip
5. Click Next and select Install
6. Repeat the Installation process for the second package Languages_Pkg_2021_03_06_001.zip

## Visual Studio Publish

Once the two package are installed Open the solution in visual studio and publish the Feature/Transator/StrikersInfy.Feature.Translator project.
1. Open Solution in Visual Studio 
2. Right Click on the Project Feature/Transator/StrikersInfy.Feature.Translator and click publish.
3. Choose the destination and click publish.

![image](https://user-images.githubusercontent.com/7092837/110210537-19fc9d00-7eb8-11eb-9272-4d0868d5af8b.png)


## Usage instructions
1. Login to Sitecore Admin.
2. Go to Content Editor
3. Navigate to the Sitecore Ribbon -> Versions-> Translator as shown below in which the highlighted is the new feature that appears

![image](https://user-images.githubusercontent.com/7092837/110210019-a194dc80-7eb5-11eb-81b1-0ab784cf0fb8.png)


4. Click on Translator, a dialog appears as below

![image](https://user-images.githubusercontent.com/7092837/110210032-b7a29d00-7eb5-11eb-8f68-eb4492bb8595.png)

5.Provide the text that is to be translated in “From text” and choose desired language as below: 
  Sample text: “How are you?”
  
  ![image](https://user-images.githubusercontent.com/7092837/110210048-d2751180-7eb5-11eb-81b3-eb65aa99af04.png)

6. Click on the translate button to fetch the desired output as shown below

  ![image](https://user-images.githubusercontent.com/7092837/110210061-ea4c9580-7eb5-11eb-9885-fe90521badca.png) 
  

### How to add Additional Language
1. Navigate to path “/sitecore/system/Languages”

2. Right Click on Langauge and choose Insert>Language

   ![image](https://user-images.githubusercontent.com/7092837/110210123-431c2e00-7eb6-11eb-9cf6-dd295a96a279.png)

3. Select the language you want and click finish the dialog

![image](https://user-images.githubusercontent.com/7092837/110210157-63e48380-7eb6-11eb-97aa-8f9a94ee2e04.png)

4. Once Language is Added Select the language and update the Display Name under Appearence Tab. (If its not show Click the View tabd and select Standard Field

![image](https://user-images.githubusercontent.com/7092837/110210215-9a220300-7eb6-11eb-9bfe-6212d9f53158.png)

5. Now open the Translate dialog it will contain the new language added.

![image](https://user-images.githubusercontent.com/7092837/110210265-d6edfa00-7eb6-11eb-83a1-1d6433b08bbc.png)

## Comments

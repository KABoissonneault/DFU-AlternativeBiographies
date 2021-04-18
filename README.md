# Varied Backstories

Mod collaboration project to add alternative biographies and backstories for your Daggerfall character.

## Background

With the introduction of [#2065](https://github.com/Interkarma/daggerfall-unity/pull/2065) to Daggerfall Unity, mods can now add alternative biography templates for each class.

But what is a biography template?

For the purpose of this mod, we consider a biography template to consist of two parts: background questions, and a backstory template (or history template). The background questions correspond to the questions asked after class selection in the character creation process, and the backstory template is used to give the character's History in the character sheet.

Each base class has its own biography templates (note: custom classes pick the "closest class", in terms of matching skills). In the base game, each class gets only one set of background questions, specified in [BIOG00T0.txt](https://github.com/Interkarma/daggerfall-unity/blob/master/Assets/StreamingAssets/BIOGs/BIOG00T0.TXT) files (where "00" corresponds to the class id, here Mage). In these files, all the questions are listed in order with their possible answers. Each answer most often has associated bonuses and penalties for the character, as well as "string ids" that will later be used by the backstory template.

For more information on the many questions, answers, and their consequences found in the base game, see <https://en.uesp.net/wiki/Daggerfall:Background>.

The character's personal History is then generated from the backstory template. For the base game's templates, these are found in `TEXT.RSC`. They have also been documented here <https://en.uesp.net/wiki/Daggerfall:Background_History> for convenience. Basically, each answer can have up to three strings associated with it, and the history uses those strings to customize the background history.

For example, in BIOG00T0.txt (the default mage biography template), the first question is "_What school of magic have you been studying the longest?_". The first possible answer is "Destruction", which is associated with the string ids 4150 and 4156, which correspond respectively to "_sending sparks of flame and ice flying around the yard_" and "_cast spells of destruction_". The mage backstory template contains the following lines:

>Your mother, a beautiful enchantress, would entertain you for hours with tricks. Your favorite was her %q1
and
>As you grew, it was apparent that you had unusually strong magical powers. Soon you were able to %q1a yourself.

%q1 and %q1a are macros for the first and second strings associated with the answer to question 1. In our example, those lines would appear in the history as

>Your mother, a beautiful enchantress, would entertain you for hours with tricks. Your favorite was her sending sparks of flame and ice flying around the yard.
and
>As you grew, it was apparent that you had unusually strong magical powers. Soon you were able to cast spells of destruction yourself.

For the other effects answers can have on a character, consult https://en.uesp.net/wiki/Daggerfall_Mod:BIOG%3F%3FT0.TXT_Files and its subpages. 

### Extensions for DFU

For the purpose of modding, we want to associate a custom backstory template with each biography template. An extension was added so that before the first question, a line that starts with "#" can be used to identify which string id is to be used for the biography template.

Ex:
```
#10000

1.	What school of magic do you think rocks hardest?
a.	Destruction
	#4150
	!4156
	?4206
	22 +6
```

This means that when DFU generates the character's History, it will request string id 10000 to the text provider, which mods can replace with a custom backstory template.

## How to contribute

This mod project aims to offer alternative biography templates for each class. Due to how the system works in Daggerfall and Daggerfall Unity, the BIOG file itself can't be shared by multiple classes, though one can of course copy-paste questions (the base game does it too), and possibly share the backstory template part.

### What we're looking for

1) a full set of 12 questions, with multiple choices of answers, rewards, and strings associated with each answer
2) a backstory template

The format of the files for either of these does not have to match that of BIOG files or RSC tokens, maintainers can adapt them as needed.

### Question Guidelines

1) Must be exactly 12 questions
2) Must include the following questions: "_What motivates you into a life of adventure?_", "_As a child, your nickname was ..._", "_What god, if any, do you worship?_". The order in which they appear does not matter. Answers and rewards will be decided globally for all classes
3) Can include questions/answers/rewards/strings copied from the original game
4) An answer can only have up to three strings to be used by the backstory. There are virtually no limits on the strings associated with an answer: nothing stops you from using it to write an entire custom paragraph per answer.
5) Rewards should keep the same balance as the base biography templates. +6 to few skills, a few low level items, a good weapon, social standing, ...
6) Do consider including the questions "_Of all disagreeable types, you have the most personal hatred for..._" and "_You are intimate friends with..._" even if they don't do anything in the base game (they could be used by another mod)

### Backstory guidelines

1) Ideally, should start from the character's "earliest memories". Unless they have amnesia, their childhood should be covered
2) Must end with Uriel Septim VII giving the character a job, ideally after establishing friendship with the emperor (classic backstories are not consistent on this). Do not specify what the job is in the backstory, so we can be consistent with custom main quest mods.
3) This is a backstory *template*. Use answers from the questions to customize the story as much as possible. Try to avoid going too deep into specific details - the more generic it is, the more room the player has to insert their own character
4) Remember that the character could be from any province of Tamriel (except Cyrodiil). Try to write a story that could conceivably work at least _somewhere_ in all provinces.

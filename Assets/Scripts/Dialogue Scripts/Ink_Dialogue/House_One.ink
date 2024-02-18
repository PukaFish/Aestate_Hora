I didn't take you as one whole likes to be indoors. #speaker:Poppy #portrait:Poppy_Neutral #layout:left
Not that I mind of course, I... #portrait:Poppy_Nervous_Side
-> AboutReading

== AboutReading ==
I like reading. It's what I do a lot of at home. #portrait:Poppy_Neutral
+ [Do you have any games you like to play?]
-> ResponseGame
+ [Books are pretty cool. Any recommendations?]
->ResponseBooks
+ [I'll go look around]
    Have fun.
-> DONE

== ResponseGame==
Like.. board games?
+ [Sure.]
    I sometimes play board games like "Billionaire" and "Connect It!" with my family.
    My mother is pretty competitive player... She usually wins...#portrait:Poppy_Done
+ [Video games perhaps?]
    My parents...
    Don't like me spending too much time playing video games. #portrait:Poppy_Nervous_Side
    -> QuestionTV
- Is there anything else? #portrait:Poppy_Questioning
-> AboutReading

==ResponseBooks==
I picked out several books that I thought were interesting. #portrait:Poppy_Happy
A lot of these books in the library is big and heavy, I don't want try reading those yet. #portrait:Poppy_Done
+ [About the fairytales on the table...]
    I like reading about princesses, phantom thieves, and all that other stuff.  #portrait:Poppy_Excited
    I wonder what it would be like in their roles...
    Do you think I would be a good phantom thief? Or maybe upcoming wizard or fashion designer?
-> ResponseBooks
+ [About the nonfiction books on the table...]
    There are a lot of debate on whether goddesses or wizards exist in a world like ours. #portrait:Poppy_Normal
    I like to think its possible... although the idea might sound a little fantasy like for you..
    I think that the nonfiction novel on Elysium and Fantasia are pretty good, even if it is from another person's point of view.
-> ResponseBooks
+ [Thanks.]
    No problem.
- Hm... #portrait:Poppy_Questioning
-> AboutReading

==QuestionTV==
I sometimes watch TV if that counts? #portrait:Poppy_Questioning
+ [What do you usually watch?]
    Mostly stuff based on fairytales. #portrait:Poppy_Normal
    Although, I sometimes watch some nature channel stuff.
    Um... Shall I tell you a fun fact?
+ [Sure.]
    (Poppy nods in acknowledgement) #portrait:Poppy_Happy
- The TV is on right now if you want to watch anything.
-> AboutReading



->END
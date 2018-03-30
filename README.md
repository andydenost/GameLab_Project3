**Game Technologies Lab**

**Haoyun Li**

**Third Project – How to preserve data between scene**

**What is the line of inquiry of my project?**

As I learn more about Unity, the game I want to make will not limit to only one
scene. However, I find unity destroys all of the object in the last scene when
it changes to another scene. That is a big limitation if I want to make a RPG
game. Because it always need to store the data and history information in some
place. If it just disappears, the game will always start from beginning. So I
need to find the way to solve this problem.

**The process of exploration**

After discussing with my classmate, I found a wrong concept about unity in my
mind. I used to think every scene has the copies of objects. If one prefabs uses
in two scenes, I think there has no relationship with them. I was totally wrong.
Every time, unity change scene, it will reload the new scene object, so
everything destroys and initializes again.

I google “how to pass data between scenes”, many articles mention
dontdestroyonload function. I try it, but I found when I go back to the original
scene there are two same objects. What’s more, as I change scene, the same
objects become more and more.

After doing research, I found the useful thing, it is called Singleton. It means
the program only exist one instance of this class. So, everyone who want the
resource can only ask from this instance. The way of realizing it is very
interesting. It makes the class instance in its own class, and the instance is
static. If there is another instance, destroy it. After doing this, the object
will not duplicate itself.

Another way to store data is very common. That is static variable in static
class. Writing this class, you should not use monobehaviour, because this class
do not attach any object. When you want to use the data, you just need to write
the class name and dot the parameter. It just like a database.

The third method is very easy to use. We could say it is a kind of database of
Unity. It was called PlayerPrefs. To use it, write like this:
PlayerPrefs.SetInt("Times",times); Give the type you want to save, in the
bracket, first parameter is the key, second parameter is the value. If you want
to get the value, just write like this: PlayerPrefs.GetInt("Times"); Provide the
key, you will get the value.

**The process of doing project.**

About my project, I use all three methods as I mentioned before.

I set two scenes, each of them has four gold balls. The player controls the
black cylinder to “eat” the gold ball. The text showing on the screen will tell
player how many gold balls he has eaten. And then the player could click Next
scene to see if the gold ball number is right. He can eat gold ball at that
scene too, it adds base on the first scene data, if he go back to the first
scene, he will see his gold number from second scene. That is like the money you
earn.

The player ID is stored by singleton, and how many times the scene has changed
is store by PlayerPrefs. Interestingly, even you close the game or close the
computer, the data never disappear. It saves itself as a file. If you want to
clear it, you need to use PlayerPrefs.DeleteAll ().

**The result**

I think PlayerPres is the best way compare to the others. Because it easy to
use, and easy to operate.

**Citation:**

<http://wiki.unity3d.com/index.php/Singleton>

<https://docs.unity3d.com/ScriptReference/PlayerPrefs.html>

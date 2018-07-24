using System;
using System.Collections.Generic;
using EventApp.Models;

namespace EventApp.DAL
{
    public class EventInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<EventContext>
    {
        protected override void Seed(EventContext context)
        {
            //list of seed events
            var events = new List<Event>
            {
                new Event{EventName="Babysitting",
                    Date =DateTime.Parse("1978-10-31"),
                    Location ="1115 Oxley Street",
                    Description ="In 1963, on Halloween night in the Midwestern United States town of Haddonfield, Illinois, Michael Myers, dressed in a clown costume and mask, inexplicably stabs his older sister Judith to death with a kitchen knife in their home. He is subsequently hospitalized at Warren County's Smith's Grove Sanitarium. Fifteen years later, on October 30, 1978, Michael's child psychiatrist, Dr. Sam Loomis, and his colleague, Marion Chambers, arrive at Smith's Grove Sanitarium to take Michael to court. Michael escapes from the sanitarium, stealing Loomis’ car. Returning home to Haddonfield, Michael kills a mechanic for his uniform and steals a white mask, a couple of knives, and some rope from a local store.  The next day, on Halloween, Michael stalks high school student Laurie Strode after she and Tommy Doyle drop off a key at his former house, so her father can sell it. Throughout the day, Laurie notices Michael following her, but her friends Annie Brackett and Lynda Van der Klok dismiss her concerns. Loomis arrives in Haddonfield in search of Michael, knowing his intentions. After discovering that Judith Myers' headstone has been stolen from the local cemetery, Loomis meets with Annie's father, Sheriff Leigh Brackett. The two begin their search at Michael's house, where Loomis tries to warn the skeptical sheriff about the danger Michael poses, explaining that Michael is pure evil and capable of further violence, despite years of catatonia. Sheriff Brackett patrols the streets while Loomis waits and watches the house, expecting Michael to return there.",
                    Guests="Michael, Laurie, Tommy, Annie, Lynda"},
                new Event{EventName="Sleepover",
                    Date =DateTime.Parse("1981-03-09"),
                    Location ="1984 Elm Street",
                    Description ="Fifteen-year-old Tina Gray is stalked through a boiler room and attacked by a disfigured man wearing a blade-fixed glove. She awakens from the nightmare, but her mother points out four mysterious slashes on her nightgown.  The following morning, Tina is consoled by her best friend, Nancy Thompson, and Nancy's boyfriend, Glen Lantz. Later, Nancy and Glen sleep at Tina's following her mother's out-of-town departure; the sleepover is interrupted by Tina's boyfriend Rod Lane. Falling asleep, Tina sees the man and runs. Awakened by Tina's thrashing, Rod witnesses her being fatally slashed by an unseen force. He flees as Nancy and Glen find Tina, mistakenly blaming Rod. Nancy tells her father, Lieutenant Don Thompson, of Tina's death.",
                    Guests ="Freddy, Nancy, Rod, Glen, Marge"},
                new Event{EventName="Bonfire party!",
                    Date =DateTime.Parse("1979-06-13"),
                    Location ="Camp Crystal Lake",
                    Description ="In the summer of 1958 at Camp Crystal Lake, two counselors named Barry and Claudette sneak away from a campfire and into a storage barn. They prepare to have sex before an unseen assailant enters and murders them.  Twenty-one years later, on June 13, newly hired camp counselor Annie Phillips asks for directions to the reopened Camp Crystal Lake.An elderly man named Crazy Ralph warns her against going, claiming that the camp has a 'death curse'. A friendly truck driver named Enos agrees to give Annie a lift halfway to the camp.During the drive, Enos warns Annie about the camp, informing her that a young boy drowned at Crystal Lake in 1957 and about the two murders the following year.After Enos drops her off, Annie hitches another ride from an unseen assailant, who chases her into the woods and slashes her throat.",
                    Guests ="Jason, Ned, Jack, Marcie, Brenda, and Alice"}
            };

            //loops through each event and adds to the initialized database
            events.ForEach(s => context.Events.Add(s));
            context.SaveChanges();
        }
    }
}
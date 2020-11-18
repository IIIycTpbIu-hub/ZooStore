using System.Threading.Tasks;

namespace ZooStore.Story
{
    public interface IStory<in TStoryContext, TStoryResult>
    {
        TStoryResult Execute(TStoryContext context);
        //Task<TStoryResult> ExecuteAsync(TStoryContext context);
    }
}

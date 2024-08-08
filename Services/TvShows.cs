
using TvShows.DB;
using TvShows.Dtos;
using TvShows.Models;

namespace TvShows.Service;

public class TvShowsService : ITvShowsService
{
    public TvShow Create(TvShowDto tvShowDto)
    {
        return TvShowsDB.CreateTvShow(tvShowDto.Name, tvShowDto.Favorite);
    }

    public bool Delete(int id)
    {
        var tvShowIndex = this.GetById(id);

        if (tvShowIndex == null) return false;

        return TvShowsDB.Remove(tvShowIndex);
    }

    public List<TvShow> GetAll()
    {
        return TvShowsDB.GetAll();
    }

    public TvShow? GetById(int id)
    {
        return TvShowsDB.GetById(id);
    }

    public TvShow? Update(int id, TvShowDto tvShowDto)
    {
        var tvs = this.GetById(id);

        if(tvs == null) return null;

        tvs.Name = tvShowDto.Name;
        tvs.Favorite = tvShowDto.Favorite;

        return tvs;
    }
}

public interface ITvShowsService
{
    TvShow Create(TvShowDto tvShowDto);
    bool Delete(int id);
    List<TvShow> GetAll();
    TvShow? GetById(int id);
    TvShow? Update(int id, TvShowDto tvShowDto);
}
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class CoreMapper
    {
        public static TD MapObject<TS,TD>(TS Source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TS, TD>();
            });
            IMapper mapper = config.CreateMapper();
            TD emp = mapper.Map<TS, TD>(Source);
            return emp;
        }
        public static  List<TD> MapList<TS, TD>(List<TS> Source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TS, TD>();
            });
            IMapper mapper = config.CreateMapper();
            List<TD> emp = mapper.Map<List<TS>, List<TD>>(Source);
            return emp;
        }
        public static  IQueryable<TD> MapIQueryable<TS, TD>(IQueryable<TS> Source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TS, TD>();
            });
            IMapper mapper = config.CreateMapper();
            IQueryable<TD> emp = mapper.Map<IQueryable<TS>, IQueryable<TD>>(Source);
            return emp;
        }
        public static  IEnumerable<TD> MapIEnumerable<TS, TD>(IEnumerable<TS> Source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TS, TD>();
            });
            IMapper mapper = config.CreateMapper();
            IEnumerable<TD> emp = mapper.Map<IEnumerable<TS>, IEnumerable<TD>>(Source);
            return emp;
        }
    }
}

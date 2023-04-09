hash_tags = {
    "kfc", "creepynuts", "fgo", "fantastics", "fanta", "gene", "coronavirus",
    "ldh", "venezuela", "video", "exiletribe", "ausopen", "iran", "breaking",
    "novelbright", "goldenglobes", "regnum", "grammys", "trumpsremovaltrial",
    "ces2020", "ebaseball", "banjir", "china", "generations", "impeach",
    "7news", "news", "straykids", "mufc", "kobebryant", "envivo", "eeuu",
    "wef20", "nba", "bts", "avonetwork", "sb54", "trump", "brexit",
    "jojo_anime", "caa", "abbtakk", "kohlsxunderarmour", "noticierovenevision",
    "kltu", "47news", "saveng", "gintama", "loveisland", "gt_pr", "enmundo",
    "letgo", "bellletstalk", "bbl09", "copadelrey", "mlkday", "pakistan",
    "tomorrow_x_together", "nec_sports", "ahora", "iraq", "india", "np", "tbt",
    "ai", "49ers", "9news", "happynewyear", "demdebate", "indvaus", "facup",
    "ufc246", "australia", "soleimani", "weather", "requestabet", "superbowl",
    "podcast", "exile", "sbliv", "climatechange", "republicday", "lfc",
    "titans", "taucepattanpabatas", "cdnpoli", "leadership", "ad",
    "impeachmenttrial", "ao2020", "us", "nfl", "free", "sagawards",
    "superbowlliv", "mondaymotivation", "ge2020", "nufc", "bbb20", "avotiara",
    "ripeanut", "whatsupatnlb", "barstow", "ciudadpreparada", "winterinla",
    "bishpleased", "celebrationoflife", "bedale", "winterinparkcity",
    "battleofbritain80", "youknowthedyl", "celebrationoflifemonth",
    "chapter100", "bronzepresident", "cancercure", "whatsupruston",
    "westbengalbjppresident", "cavs50th", "burneside", "av411", "chapter103",
    "burnham", "cambs", "westbengalgovernor", "westbengallottery",
    "celebrationofservice", "barsul_jagoroni_sangha", "yehwohmanziltonahin",
    "bismidbeauty", "aurusmotors", "winterlandscape", "yelverton",
    "classicsunwrapped", "buron", "backintime", "celebratelodge49",
    "westendlive", "yemancantwait", "christopherplummer", "bidorbuy",
    "camelscare", "celebratelight", "yemasseesc", "celebratelife", "bestoffive",
    "camelshead", "bloquean", "barlach", "beddingham", "awx", "yeltztv",
    "braceyourself", "westdunbartonshire", "celebrateresponsibly",
    "civicaction", "betrandpeto", "wkyt", "charanraj", "baskenland", "wkyr",
    "aymsports", "christophersimmonds", "cazzaroverde", "whatsonni", "backlift",
    "audioporn", "bestoflomo2019", "celebratefsu", "bids", "bbk", "wkdarts",
    "westernbalkan", "christophsietzen", "whatshesaid", "buttsex",
    "whatshappeningongbf", "betovennalajni", "bisonpride", "backjarlath",
    "canberrabubble", "bracketracing", "canavese", "burqaban", "ausaotw2020",
    "britaingettalking", "bjpmadedisaster", "civiccenter", "cb125f",
    "bestofirokotvmovies", "wkoa", "whatsinmymouthgame", "yelpelite",
    "bbcnewvoices", "balbina", "camelfolk", "balbidramas", "cheetahgirls",
    "winterize", "brassknucklez", "banditatip", "celebratethewin", "burnstown",
    "holamatchfm", "visitburbank", "mescidiaksa", "visitcalifornia", "comente",
    "virginexpress", "number24", "greatpresidentsnever", "greatreads", "exdem",
    "greco", "financialabuse", "visitirving", "chichaday", "quesada", "pareja",
    "quesigacreciendoelclan", "mtlvsdet", "quantique", "exchangerate",
    "experienciatacoma2020", "questforthecup", "wellconnected", "mess",
    "automatizaciones", "affaires", "zagrebblogs", "atttv", "executivelounge",
    "harstad", "meredithmontero", "fritz", "actually", "nuevasegovia",
    "harukanakagawa", "harvest", "exn2", "cleanseas", "visitutah", "frog",
    "aaunchained", "6yearsspinningwithgot7", "hartpury",
    "mtvbasebehindthestory", "xe", "hohenfels", "queenannes", "expelfidesz",
    "expeditionbigfoot", "fromh", "pig", "bandera", "automobili",
    "browardcounty", "allianzleague", "mentoringmatters", "werderu19",
    "vivelaexperiencia", "virtualcare", "ntrdeathanniversary", "romancenovel",
    "accuweather", "qldcamp2020", "x19", "brocklesnar", "memvsdet",
    "picosdeeuropa", "multas", "vive", "pickyourpriceblast", "rmfhassist",
    "quinnliu", "qcrime", "fileninakrepleri", "nike_one", "evolve", "rmpg_dope",
    "hmcolombia", "romatermini", "zanda", "pickswiselive", "meteorologists",
    "menatwork", "nuncamexa", "quad3", "bwca", "clausura20", "mujersegura",
    "hollandaligi", "avocados", "comisiones", "pinguinos2020", "bandaeva",
    "byuvuclavusu", "6ix9ine", "rohboheme", "fromwashington",
    "golddemandtrends", "roladeldiaghl", "gastospersonales", "friendfriday"
}

reqs = {}
for i, tag in ipairs(hash_tags) do
    path = "/Raven/Tag?hashtag=" .. tag
    reqs[i] = path
end

counter = 0

request = function()
    local r = {}
    for i = 1, depth do
        counter = counter + 1
        local index = (counter % #reqs) + 1
        r[i] = wrk.format("GET", reqs[index])
    end
    req = table.concat(r)
    return req
end


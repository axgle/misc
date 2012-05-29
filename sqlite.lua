--https://github.com/LuaDist/luasql-sqlite3/blob/master/tests/test.lua

require"luasql.sqlite3"
env = luasql.sqlite3()
db = assert(env:connect("test.db"))

db:setautocommit(false)
db:execute[[create table test(id integer primary key)]]

db:execute[[insert into test values(null)]]
db:commit()

res=db:execute[[select * from test order by id desc limit 3]]

row = {}
while res:fetch(row,"a") do
  --print(table.concat(row,'|'))
  print(row.id)
end
 
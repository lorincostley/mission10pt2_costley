import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlingList() {
  const [bowlingData, setBowlingData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlingData = async () => {
      const rsp = await fetch('http://localhost:5099/MainBowling');
      const f = await rsp.json();
      setBowlingData(f);
    };
    fetchBowlingData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Best Bowlers</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Vendor Name</th>
            <th>Food Rating</th>
          </tr>
        </thead>
        <tbody>
          {bowlingData.map((f) => (
            <tr key={f.bowlerid}>
              <td>{f.bowlerlastname}</td>
              <td>{f.bowlerfirstname}</td>
              <td>{f.bowlermiddleinit}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlingList;

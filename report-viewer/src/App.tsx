import { useState } from 'react'
import logo from './logo.svg'
import REPORT from './report.json'
import './App.css'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      {REPORT.filter((a) => a != null).map((report_item, ix) => (
        <div style={{display: "flex", background: ix % 2== 0 ? '#dfdfdf' : '#fff', padding: '20px', flexDirection: 'row', borderBottom: '1px solid black'}}>
          <div style={{flex: 1, display: 'flex', flexDirection: 'column', alignItems: 'flex-start'}}>
            {/* <div>Date of welding: </div> */}
            {/* <div>Time of welding: </div> */}
            <div>Ambient Temperature: {report_item?.AmbientTemperature}</div>
            <div>Version: {report_item?.Version}</div>
            <div>Serial number: {report_item?.SerialNumber}</div>

            <div>Welding number: {report_item?.WeldingNumber}</div>
            <div>Minimum tension: {report_item?.MinimumTension}</div>
            <div>Maximum tension: {report_item?.MaximumTension}</div>
            <div>Time elapsed: {report_item?.TimeElapsed}</div>
            <div>Supplied energy: {report_item?.SuppliedEnergy}</div>
            <div>Measured resistance: {report_item?.MeasuredResistance}</div>
          </div>
          <div style={{flex: 1, display: 'flex', flexDirection: 'column', alignItems: 'flex-start'}}>
            <div>Type: {report_item?.JointData.Type}</div>
            <div>Trademark: {report_item?.JointData.Trademark}</div>
            <div>Cooling: {report_item?.JointData.Cooling}</div>
            <div>Diameter: {report_item?.JointData.Diameter}</div>
            <div>Voltage: {report_item?.JointData.Voltage}</div>
            <div>{report_item?.JointData.Time}</div>
          </div>
          <div style={{flex: 1, display: 'flex', flexDirection: 'column', alignItems: 'flex-start'}}>
            <div>Depth of trench: {report_item?.TrenchDepth}</div>
            </div>
        </div>
      ))}
    </div>
  )
}

export default App
